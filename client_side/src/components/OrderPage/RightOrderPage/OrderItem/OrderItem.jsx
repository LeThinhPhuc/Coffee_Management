import { useContext, useState } from "react";
import { MenuContext } from "../../../../context/MenuContext";
import { Input } from "@material-tailwind/react";

const OrderItem = ({ items, setChangeCnt, changeCnt }) => {
  const { deleteOutSelectedOnOrder, selectedDrink } = useContext(MenuContext);
  const [cnt, setCnt] = useState(items.quantity);

  const handleDecrease = () => {
    if (cnt > 1) {
      setCnt(cnt - 1);
    }
    if (cnt == 1) {
      deleteOutSelectedOnOrder(items);
    }
  };

  const handleIncrease = () => {
    setCnt(cnt + 1);
  };

  useEffect(() => {
    // Cập nhật giá trị soluong trong items khi cnt thay đổi
    items.quantity = cnt;

    setChangeCnt(changeCnt + 1);
  }, [cnt]);

  const handleChange = (e) => {
    items.note = e.target.value;
    console.log(items.note);
  };

  return (
    <div className="flex justify-between pr-2 pl-2 pb-3">
      <div className="flex items-center justify-center">
        <img
          className="w-[4vw] h-[5vw] rounded-lg"
          src={items?.imagePath}
          alt="Coffee"
        />
        <div className="pl-2">
          <div className="font-bold text-[#6f4436]">{items.name}</div>
          <div>{items.price * cnt} VND</div>
          <input
            onChange={(e) => handleChange(e)}
            placeholder="Note here !"
            className="bg-[#ffffff] bg-opacity-10 border-b-4 pl-2 border-t-0 border-l-0 border-r-0 border-[#6f4436] w-[14vw] font-[#6f4436]"
          />
        </div>
      </div>

      <div className="flex items-center ">
        <button
          onClick={handleDecrease}
          className="flex justify-center items-center bg-[#6f4436] rounded-[100%] w-[2.5vw] h-[2.5vw] text-[1.5vw] text-white cursor-pointer"
        >
          -
        </button>
        <div className="p-2">{cnt}</div>
        <button
          onClick={handleIncrease}
          className="flex justify-center items-center bg-[#6f4436] rounded-[100%] w-[2.5vw] h-[2.5vw] text-[1.5vw] text-white cursor-pointer"
        >
          +
        </button>
        {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
      </div>
    </div>
  );
};

export default OrderItem;
