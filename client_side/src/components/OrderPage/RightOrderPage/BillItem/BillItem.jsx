import { formatCurrency } from "../../../../utils/utils"

const BillItem = ({items})=>{
    return(
        <div className="flex justify-between pr-2 pl-2 pb-3">
        <div className="flex items-center justify-center">
            <div className="pl-2">
                <div className="font-bold text-[#6f4436]">{items.name}</div>
                <div>{items.quantity}    x    {formatCurrency(items.price)}</div>
            </div>
        </div>

        <div className="flex items-center ">
            <div className="p-2">{formatCurrency(items.price*items.quantity)}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
            {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
        </div>
    </div>
    )
}
export default BillItem