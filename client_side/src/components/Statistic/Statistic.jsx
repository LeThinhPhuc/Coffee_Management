import FavoriteGraph from "./FavoriteGraph/FavoriteGraph";
import RevenueGraph from "./RevenueGraph/RevenueGraph";
import StatisticByType from "./StatisticByType/StatisticByType";
import Status from "./Status/Status";
import Table from "./Table/Table";
const Statistic = () => {
    return (
        <div className="pt-6 px-4">
            <div className="w-full grid grid-cols-1 xl:grid-cols-3 gap-4">
                <RevenueGraph /> 
                <div className="grid grid-rows-5 gap-4">
                    <Status /> 
                    <StatisticByType /> 
                </div>
            </div>
            <div className="w-full grid grid-cols-1 xl:grid-cols-3 gap-4 my-4">
                <Table />
                <FavoriteGraph />
            </div>
        </div>
    );
};

export default Statistic;
