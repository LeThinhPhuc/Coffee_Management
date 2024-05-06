import { useEffect, useState } from "react";
import { Line } from "react-chartjs-2";
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Filler,
  Tooltip,
  Legend,
} from "chart.js";
ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Filler,
  Tooltip,
  Legend
);

const options = {
  responsive: true,
  plugins: {
    legend: {
      position: "bottom",
    },
    title: {
      display: false,
      text: "Thống kê doanh thu",
    },
  },
};

const fakeData = [
  {
    nameDrink: "Strawberry Banana Smoothie",
    total: [22, 33, 19, 80, 30, 66, 42],
  },
  {
    nameDrink: "Mango Pineapple Smoothie",
    total: [72, 53, 79, 30, 50, 61, 70],
  },
  {
    nameDrink: "Pie Mango Smoothie",
    total: [12, 23, 49, 70, 80, 40, 50],
  },
];

const StatisticByType = () => {
  // Cấu hình cho Line Chart
  const [labels, setLabels] = useState([]);
  const [dataset, setDataset] = useState([]);
  const color = [
    "rgba(52, 99, 132, 0.5)",
    "rgba(255, 99, 132, 0.5)",
    "rgba(75, 192, 192, 0.5)",
  ];
  const dataOfChart = {
    labels: [
      "Thứ Hai",
      "Thứ Ba",
      "Thứ Tư",
      "Thứ Năm",
      "Thứ Sáu",
      "Thứ Bảy",
      "Chủ Nhật",
    ],
    // datasets: [
    //   {
    //     label: fakeData[0].nameDrink,
    //     data: fakeData[0].total,
    //     backgroundColor: "rgba(52, 99, 132, 0.5)",
    //   },
    //   {
    //     label: fakeData[1].nameDrink,
    //     data: fakeData[1].total,
    //     backgroundColor: "rgba(255, 99, 132, 0.5)",
    //   },
    // ],
    datasets: fakeData.map((item, index) => ({
      label: item.nameDrink,
      data: item.total,
      backgroundColor: color[index],
    })),
  };

  // Dropdown
  const menus = ["Juice", "Smoothie", "Tea", "Coffee"];
  const [menu, setMenu] = useState();
  const [showMenu, setShowMenu] = useState(false);

  // Chọn loại
  const handleClickMenu = (opt) => {
    setShowMenu(!showMenu);
    setMenu(opt);
  };

  // Chọn tuần
  const [value, setValue] = useState({ startDate: null, endDate: null });

  const handleChangeWeek = (event) => {
    const weekValue = event.target.value;
    const value2 = getStartAndEndOfWeek(weekValue);
    setValue(value2);

    //gọi hàm handle
    console.log(value);
  };
  useEffect(() => {
    console.log("useEffect: " + value);
  }, [value]);
  const getStartAndEndOfWeek = (weekValue) => {
    // Tách năm và tuần từ đầu vào
    const [year, weekNumber] = weekValue.split("-W").map(Number);

    // Tạo ngày mùng 1 tháng 1 của năm đó
    const januaryFirst = new Date(year, 0, 1);

    // Xác định ngày bắt đầu của tuần theo chuẩn ISO-8601
    // - Thứ 4 ngày 4 của tháng 1 thường thuộc tuần 1
    // - Thứ 2 là ngày đầu tuần theo chuẩn ISO-8601
    const daysToMonday = (januaryFirst.getDay() + 6) % 7; // tính toán số ngày đến thứ 2
    const firstMonday = new Date(januaryFirst);
    firstMonday.setDate(januaryFirst.getDate() - daysToMonday + 1);

    // Tính ngày đầu tiên của tuần
    const startDate = new Date(firstMonday);
    startDate.setDate(startDate.getDate() + (weekNumber - 1) * 7);

    // Tính ngày cuối tuần (Chủ Nhật)
    const endDate = new Date(startDate);
    endDate.setDate(startDate.getDate() + 6);

    const startD = startDate.toISOString().split("T")[0];
    const endD = endDate.toISOString().split("T")[0];

    return { startD, endD };
  };
  return (
    <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 row-span-4  ">
      <div className="w-full flex justify-between mb-2">
        <div className="">
          <h3 className="text-xl font-bold text-gray-900 mb-2">
            Doanh Thu Theo Loại
          </h3>
          <input type="week" onChange={handleChangeWeek} />
        </div>

        <div className="relative inline-block text-left">
          <div>
            <button
              type="button"
              className="inline-flex w-full justify-center gap-x-1.5 rounded-md bg-white px-3 py-2 text-sm font-semibold text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 hover:bg-gray-50"
              id="menu-button"
              aria-expanded="true"
              aria-haspopup="true"
              onClick={() => setShowMenu(!showMenu)}
            >
              Loại
              <svg
                className="-mr-1 h-5 w-5 text-gray-400"
                viewBox="0 0 20 20"
                fill="currentColor"
                aria-hidden="true"
              >
                <path
                  fillRule="evenodd"
                  d="M5.23 7.21a.75.75 0 011.06.02L10 11.168l3.71-3.938a.75.75 0 111.08 1.04l-4.25 4.5a.75.75 0 01-1.08 0l-4.25-4.5a.75.75 0 01.02-1.06z"
                  clipRule="evenodd"
                />
              </svg>
            </button>
          </div>
          {/* Dropdown Options */}
          {showMenu && (
            <div
              className="absolute right-0 z-10 mt-2 w-30 origin-top-right rounded-md bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none"
              role="menu"
              aria-orientation="vertical"
              aria-labelledby="menu-button"
              tabIndex="-1"
            >
              <div className="py-1" role="none">
                {menus.map((m) => (
                  <a
                    key={m}
                    href="#"
                    className="text-gray-700 block px-4 py-2 text-sm hover:bg-gray-100"
                    role="menuitem"
                    tabIndex="-1"
                    onClick={() => handleClickMenu(m)}
                  >
                    {m}
                  </a>
                ))}
              </div>
            </div>
          )}
        </div>
      </div>

      {/* Line Chart */}
      <div className="h-[200px]">
        <Line options={options} data={dataOfChart} />
      </div>
    </div>
  );
};

export default StatisticByType;
