import LeftOrderPage from "./LeftOrderPage/LeftOrderPage";
import RightOrderPage from "./RightOrderPage/RightOrderPage";

const OrderPage = () => {
    return (
        <div className="grid grid-cols-1 sm:grid-cols-10">
        <div className="sm:col-span-7 pt-2 pl-1 pr-1 overflow-auto">
            <LeftOrderPage />
        </div>
        <div className="sm:col-span-3 overflow-auto sticky top-0 h-screen">
            <RightOrderPage />
        </div>
    </div>
    
    
    )
}
export default OrderPage;
