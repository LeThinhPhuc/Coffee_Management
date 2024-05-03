import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  BarElement,
  Title,
  Tooltip,
  Legend,
} from "chart.js";
import Datepicker from "react-tailwindcss-datepicker";
import { Bar } from "react-chartjs-2";
import { useEffect, useState } from "react";
ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  BarElement,
  Title,
  Tooltip,
  Legend
);

const options = {
  responsive: true,
  plugins: {
    legend: {
      position: top,
    },
    title: {
      display: false,
      text: "Thống kê doanh thu",
    },
  },
};
const fakeDatabyYear = [
  {
    month: "January",
    total: 85,
  },
  {
    month: "February",
    total: 82,
  },
  {
    month: "March",
    total: 25,
  },
  {
    month: "April",
    total: 25,
  },
  {
    month: 5,
    total: 25,
  },
  {
    month: 6,
    total: 25,
  },
  {
    month: 7,
    total: 25,
  },
  {
    month: 8,
    total: 25,
  },
  {
    month: 9,
    total: 25,
  },
  {
    month: 10,
    total: 25,
  },
  {
    month: 11,
    total: 25,
  },
  {
    month: 12,
    total: 25,
  },
];

const fakeData = [
  {
    orderDate: "2024-4-20",
    total: 5.5,
  },
  {
    orderDate: "2024-4-21",
    total: 4.9,
  },
  {
    orderDate: "2024-4-22",
    total: 7.2,
  },
  {
    orderDate: "2024-4-23",
    total: 10,
  },
  {
    orderDate: "2024-4-24",
    total: 7.4,
  },
  {
    orderDate: "2024-4-25",
    total: 5.1,
  },
  {
    orderDate: "2024-4-26",
    total: 7.8,
  },
  {
    orderDate: "2024-4-27",
    total: 6.9,
  },
  {
    orderDate: "2024-4-28",
    total: 7.1,
  },
  {
    orderDate: "2024-4-29",
    total: 3.9,
  },
  {
    orderDate: "2024-4-30",
    total: 8.3,
  },
  {
    orderDate: "2024-5-1",
    total: 9.2,
  },
  {
    orderDate: "2024-5-2",
    total: 10.5,
  },
  {
    orderDate: "2024-5-3",
    total: 13,
  },

  {
    orderDate: "2024-4-23",
    total: 10,
  },
  {
    orderDate: "2024-4-24",
    total: 7.4,
  },
  {
    orderDate: "2024-4-25",
    total: 5.1,
  },
  {
    orderDate: "2024-4-26",
    total: 7.8,
  },
  {
    orderDate: "2024-4-27",
    total: 6.9,
  },
  {
    orderDate: "2024-4-28",
    total: 7.1,
  },
  {
    orderDate: "2024-4-29",
    total: 3.9,
  },
  {
    orderDate: "2024-4-30",
    total: 8.3,
  },
  {
    orderDate: "2024-5-1",
    total: 9.2,
  },
  {
    orderDate: "2024-5-2",
    total: 10.5,
  },
  {
    orderDate: "2024-5-3",
    total: 13,
  },
];

const RevenueGraph = () => {
  // Cấu hình cho Line Chart
  const [labels, setLabels] = useState([]);
  const [dataset, setDataset] = useState([]);

  useEffect(() => {
    const orderDates = fakeData.map((item) => item.orderDate);
    const totals = fakeData.map((item) => item.total);
    setLabels(orderDates);
    setDataset(totals);
  }, []);
  const data = {
    labels,
    datasets: [
      {
        label: "Doanh thu",
        data: dataset,
        backgroundColor: "rgba(255, 99, 132, 0.5)",
      },
    ],
  };

  // Date Range Piker
  const [value, setValue] = useState({
    startDate: null,
    endDate: null,
  });

  const handleValueChange = (newValue) => {
    console.log("newValue:", newValue);
    setValue(newValue);
  };

  // Khai báo các Option thống kê theo tuần, tháng, năm
  const menus = ["Tuần", "Tháng", "Năm", "Custom"];
  const [menu, setMenu] = useState();
  const [showMenu, setShowMenu] = useState(false);

  // Chọn dropdown opstions
  const handleClickMenu = (opt) => {
    setShowMenu(!showMenu);
    setMenu(opt);
  };

  // Hiện doanh thu theo tháng
  const handleChangeMonth = (event) => {
    // Lấy khoảng thời gian trong tháng
    // ngày đầu tiên của tháng
    const startDate = `${event.target.value}-01`;

    // Tạo ngày đầu tiên của tháng tiếp theo, sau đó lùi lại một ngày
    const end = new Date(startDate);
    end.setMonth(end.getMonth() + 1);
    end.setDate(end.getDate() - 1);
    const endDate = end.toISOString().split("T")[0];

    setValue({ startDate, endDate });
    setDataByDateRange(startDate, endDate);
  };
  const handleChangeWeek = (event) => {
    const weekValue = event.target.value;
    const value2 = getStartAndEndOfWeek(weekValue);
    setValue(value2);
    setDataByDateRange(value2[0], value2[1]);
    console.log(value);
  };
  const handleChangeYear = (event) => {
    const months = fakeDatabyYear.map((item) => item.month);
    const totals = fakeDatabyYear.map((item) => item.total);
    setLabels(months);
    setDataset(totals);
  };
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

    return { startDate, endDate };
  };
  // Chart thay đổi khi value thay đổi
  const setDataByDateRange = (start, end) => {
    setLabels([...labels]);
    setDataset([...dataset]);
  };
  return (
    <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 col-span-2">
      <div className="flex justify-between mb-2">
        <div>
          <h3 className="text-xl font-bold text-gray-900 mb-2">
            {!menu && "Doanh Thu Cửa hàng"}
            {menu && `Doanh Thu Theo ${menu}`}
          </h3>
          <div className="h-8">
            {menu === "Tuần" && (
              <input type="week" onChange={handleChangeWeek} />
            )}
            {menu === "Tháng" && (
              <input type="month" onChange={handleChangeMonth} />
            )}
            {menu === "Năm" && (
              <input
                type="number"
                onChange={handleChangeYear}
                placeholder="2024"
                min={2023}
                max={2025}
                className="px-2"
              />
            )}
            {menu === "Custom" && (
              <Datepicker
                primaryColor={"amber"}
                showShortcuts={true}
                separator={"đến"}
                value={value}
                onChange={handleValueChange}
                displayFormat={"DD/MM/YYYY"}
                containerClassName={"w-[300px] relative"}
              />
            )}
          </div>
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
              Options
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

      <Bar options={options} data={data} />
    </div>
  );
};

export default RevenueGraph;
