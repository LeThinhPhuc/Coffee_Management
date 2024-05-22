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
import { useDispatch, useSelector } from "react-redux";
import { useEffect, useState } from "react";
import {
  dailyInRange,
  monthsByYear,
} from "../../../redux/Reducer/statisticSlice";
import {
  fetchDailyInRange,
  fetchMonthlyByYear,
} from "../../../redux/Action/statisticAction";
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
    },
  },
};

const RevenueGraph = () => {
  const dispatch = useDispatch();
  const dailyRange = useSelector(dailyInRange);
  const monthRevenue = useSelector(monthsByYear);
  // startDate & endDate
  const [value, setValue] = useState({
    startDate: "2024-05-01",
    endDate: "2024-05-30",
  });
  const [year, setYear] = useState();
  // Khai báo các Option thống kê theo tuần, tháng, năm
  const menus = ["Tuần", "Tháng", "Năm", "Custom"];
  const [menu, setMenu] = useState();
  const [showMenu, setShowMenu] = useState(false);

  const data = {
    labels:
      menu == "Năm"
        ? monthRevenue
          ? monthRevenue.map((item) => item.month)
          : []
        : dailyRange
        ? dailyRange.map((item) => item.date.split("T")[0])
        : [],
    datasets: [
      {
        label: "Doanh thu",
        data:
          menu == "Năm"
            ? monthRevenue
              ? monthRevenue.map((item) => item.revenue)
              : []
            : dailyRange
            ? dailyRange.map((item) => item.revenue)
            : [],
        backgroundColor: "rgba(255, 99, 132, 0.5)",
      },
    ],
  };

  useEffect(() => {
    console.log(`${value.startDate} to ${value.endDate}`);
    if (value.startDate && value.endDate) {
      dispatch(fetchDailyInRange(value.startDate, value.endDate))
        .then(() => console.log(dailyRange))
        .catch((error) => console.error("Error fetching data:", error));
    }
  }, [dispatch, value]);

  useEffect(() => {
    console.log(year);
    if (year) {
      dispatch(fetchMonthlyByYear(year))
        .then(() => console.log(monthRevenue))
        .catch((error) => console.error("Error fetching data:", error));
    }
  }, [dispatch, year]);

  // Custom Date Range
  const handleValueChange = (newValue) => {
    setValue(newValue);
  };

  // Chọn dropdown opstions
  const handleClickMenu = (opt) => {
    setShowMenu(!showMenu);
    setMenu(opt);
    // chọn Year thì chart sẽ tự động fetchMonthlyByYear
    if (opt === "Năm") {
      setYear(2024);
      dispatch(fetchMonthlyByYear(2024)).catch((error) =>
        console.error("Error fetching data:", error)
      );
    }
  };
  // Xử lý giá trị ngày khi chọn week
  const handleChangeWeek = (event) => {
    const weekValue = event.target.value;
    const value2 = getStartAndEndOfWeek(weekValue);
    setValue(value2);
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

    const startD = startDate.toISOString().split("T")[0];
    const endD = endDate.toISOString().split("T")[0];

    return { startDate: startD, endDate: endD };
  };

  // Lấy startDate & endDate của tháng
  const handleChangeMonth = (event) => {
    // ngày đầu tiên của tháng
    const startDate = `${event.target.value}-01`;

    // Tạo ngày đầu tiên của tháng tiếp theo, sau đó lùi lại một ngày
    const end = new Date(startDate);
    end.setMonth(end.getMonth() + 1);
    end.setDate(end.getDate() - 1);
    const endDate = end.toISOString().split("T")[0];

    setValue({ startDate, endDate });
  };

  const handleChangeYear = (event) => {
    setYear(event.target.value);
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
                min={2020}
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
