import { useSelector } from "react-redux";
import { Chart as ChartJS, ArcElement, Tooltip, Legend } from "chart.js";
import { Pie } from "react-chartjs-2";
import { lastMonthByType } from "../../../redux/Reducer/statisticSlice";
ChartJS.register(ArcElement, Tooltip, Legend);

const fakeData = [
  { type: "Tea", total: 30 },
  { type: "Coffe", total: 26 },
  { type: "Juice", total: 15 },
  { type: "Smoothie", total: 14 },
  { type: "Teaa", total: 20 },
];

const FavoriteGraph = () => {
  const revenue = useSelector(lastMonthByType);
  console.log(revenue);
  const data = {
    labels: revenue?.map((item) => item.type),
    datasets: [
      {
        label: "# of Votes",
        data: revenue?.map((item) => item.total),
        backgroundColor: [
          "rgba(255, 99, 132, 0.2)",
          "rgba(54, 162, 235, 0.2)",
          "rgba(255, 206, 86, 0.2)",
          "rgba(75, 192, 192, 0.2)",
          "rgba(153, 102, 255, 0.2)",
          "rgba(255, 159, 64, 0.2)",
        ],
        borderColor: [
          "rgba(255, 99, 132, 1)",
          "rgba(54, 162, 235, 1)",
          "rgba(255, 206, 86, 1)",
          "rgba(75, 192, 192, 1)",
          "rgba(153, 102, 255, 1)",
          "rgba(255, 159, 64, 1)",
        ],
        borderWidth: 1,
      },
    ],
  };
  const options = {
    plugins: {},
  };
  return (
    <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 flex-row">
      <h3 className="text-xl font-bold text-gray-900 mb-2">
        Loại Được Yêu Thích Trong Tháng
      </h3>
      <div className="h-96 flex justify-center">
        <Pie data={data} options={options} />
      </div>
    </div>
  );
};

export default FavoriteGraph;
