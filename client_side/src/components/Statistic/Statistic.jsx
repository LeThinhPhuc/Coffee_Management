import FavoriteGraph from "./FavoriteGraph/FavoriteGraph";
import RevenueGraph from "./RevenueGraph/RevenueGraph";
import Table from "./Table/Table";

const Statistic = () => {
  return (
    <div className="pt-6 px-4">
      <div className="w-full grid grid-cols-1 xl:grid-cols-2 2xl:grid-cols-3 gap-4">
        <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 ">
          <RevenueGraph />
        </div>
      </div>
      <div className="w-full grid grid-cols-1 xl:grid-cols-3 2xl:grid-cols-12 gap-4 my-4">
        <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 xl:col-span-2">
          <Table />
        </div>
        <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8  2xl:col-span-2 h-96">
          <FavoriteGraph />
        </div>
      </div>
    </div>
  );
};

export default Statistic;
