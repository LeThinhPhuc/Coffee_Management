import { formatCurrency } from "../../../utils/utils"

const Bill = ({items})=>{
    console.log(items?.quanity)
    return(
        <div className="flex justify-between pr-2 pl-2 pb-3">
        <div className="flex items-center justify-center">
            <div className="pl-2">
                <div className="font-bold text-[#6f4436]">{items?.drink?.name}</div>
                <div>Số lượng: {items?.quanity}</div>
            </div>
        </div>

        <div className="flex items-center ">
            <div className="p-2">{formatCurrency(items?.drink?.price*items?.quanity)}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
        </div>
    </div>
    )
}
export default Bill