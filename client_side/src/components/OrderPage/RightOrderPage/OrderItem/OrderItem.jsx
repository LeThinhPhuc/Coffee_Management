import { useContext, useEffect, useState } from "react";
import { MenuContext } from "../../../../context/MenuContext";

const OrderItem = ({ items, setChangeCnt, changeCnt }) => {
    const { deleteOutSelected , selectedDrink} = useContext(MenuContext);
    const [cnt, setCnt] = useState(items.soluong);

    const handleDecrease = () => {
        if (cnt > 1) {
            setCnt(cnt - 1); // Giảm giá trị của cnt khi giảm số lượng
            
        }
    };

    const handleIncrease = () => {
        setCnt(cnt + 1); // Tăng giá trị của cnt khi tăng số lượng
    };

    useEffect(() => {
        // Cập nhật giá trị soluong trong items khi cnt thay đổi
        items.soluong = cnt;

        setChangeCnt(changeCnt+1)
    }, [cnt]);

    return (
        <div className="flex justify-between pr-2 pl-2 pb-3">
            <div className="flex items-center justify-center">
                <img className="w-[4vw] rounded-lg" src={items.image} alt="Coffee" />
                <div className="pl-2">
                    <div className="font-bold text-[#6f4436]">{items.name}</div>
                    <div>{items.price * cnt} VND</div>
                </div>
            </div>

            <div className="flex items-center ">
                <button onClick={handleDecrease} className="flex justify-center items-center bg-[#6f4436] rounded-[100%] w-[2.5vw] h-[2.5vw] text-[1.5vw] text-white cursor-pointer">-</button>
                <div className="p-2">{cnt}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                <button onClick={handleIncrease} className="flex justify-center items-center bg-[#6f4436] rounded-[100%] w-[2.5vw] h-[2.5vw] text-[1.5vw] text-white cursor-pointer">+</button>
                {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
            </div>
        </div>
    );
};

export default OrderItem;
