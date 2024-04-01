import { useContext, useState } from "react";
import { MenuContext } from "../../../../context/MenuContext";

const OrderItem = ({items}) => {
    const {deleteOutSelected}=useContext(MenuContext)
    const [cnt, setCnt] = useState(1);

    const handleDecrease = () => {
        if (cnt > 1) {
            setCnt(cnt - 1);
        }
    };

    const handleIncrease = () => {
        setCnt(cnt + 1);
    };

    return (
        <div className="flex justify-between pr-2 pl-2 pb-3">
            <div className="flex items-center justify-center">
                <img className="w-[4vw] rounded-lg" src={items.image} alt="Coffee" />
                <div className="pl-2">
                    <div className="font-bold text-[#6f4436]">{items.name}</div>
                    <div>{items.price*cnt} VND</div>
                </div>
            </div>

            <div className="flex items-center ">
                <button onClick={handleDecrease} className="flex justify-center items-center bg-[#6f4436] rounded-[100%] w-[2.5vw] h-[2.5vw] text-[1.5vw] text-white cursor-pointer">-</button>
                <div className="p-2">{cnt}</div>
                <button onClick={handleIncrease} className="flex justify-center items-center bg-[#6f4436] rounded-[100%] w-[2.5vw] h-[2.5vw] text-[1.5vw] text-white cursor-pointer">+</button>
                {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
            </div>
        </div>
    );
};

export default OrderItem;
