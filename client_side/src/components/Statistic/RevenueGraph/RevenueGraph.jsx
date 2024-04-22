import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  BarElement,
  Title,
  Tooltip,
  Legend,
} from "chart.js";
import { Bar } from "react-chartjs-2";
ChartJS.register(
  CategoryScale,
  LinearScale,
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
      display: true,
      text: "",
    },
  },
};

const labels = ["January", "February", "March", "April", "May", "June", "July"];

const data = {
  labels,
  datasets: [
    {
      label: "Doanh thu",
      data: [
        50000000, 48000000, 100000000, 89000000, 20000000, 15000000, 30000000,
      ],
      backgroundColor: "rgba(255, 99, 132, 0.5)",
    },
    // {
    //   label: "Dataset 2",
    //   data: [
    //     50000000, 48000000, 100000000, 89000000, 20000000, 15000000, 30000000,
    //   ],
    //   backgroundColor: "rgba(53, 162, 235, 0.5)",
    // },
  ],
};

const RevenueGraph = () => {
  return <Bar options={options} data={data} />;
};

export default RevenueGraph;
