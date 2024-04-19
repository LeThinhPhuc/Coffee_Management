import { useContext, useEffect, useState } from "react";
import Modal from "../Modal/Modal";
import OrderItem from "./OrderItem/OrderItem";
import '../../../App.css'
import {Textarea} from '@material-tailwind/react'
import { MenuContext } from "../../../context/MenuContext";
import CardVoucher from "./CardVoucher/CardVoucher";
import BillItem from "./BillItem/BillItem";
import { useDispatch} from 'react-redux';
import { addOrder } from "../../../redux/Action/orderAction";
const RightOrderPage = () => {
    const { selectedDrink, addSelectedDrink, checkModalVoucher, setCheckModalVoucher, voucherValue } = useContext(MenuContext)
    const [checkModal, setCheckModal] = useState(false);
    const [checkOrderFinal, setCheckOrderFinal] = useState(false)
    const [changeCnt, setChangeCnt] = useState(0)
    const [note, setNote] = useState("");
    const dispatch = useDispatch();

    const handleModal = () => {
        setCheckModal(!checkModal);
    }



    const handleModelOrder = () => {
        console.log("bill order: ", { selectedDrink: selectedDrink, total: total() - discount() })
        const data ={userId:"1",total:total()-discount(),orderItems:selectedDrink}
        dispatch(addOrder(data))
        
        setCheckOrderFinal(!checkOrderFinal)
        console.log("thong tin order: ",data)
    }

    const handleChose = (tmp) => {
        setCheckModal(tmp)
    }

    useEffect(() => {
        total();
        discount()
    }, [changeCnt])
    const total = () => {
        let sum = 0;

        if (selectedDrink) {
            for (let i = 0; i < selectedDrink.length; i++) {
                sum += (selectedDrink[i].price * selectedDrink[i].quantity)
            }
        }
        return sum;
    }

    const writeNote =(e)=>{
        console.log(e.target.value)
        setNote(e.target.value);
    }
    const discount = () => {
        let to = total();
        if (voucherValue) {
            return to * voucherValue.discount / 100;

        } else {
            return 0;
        }

    }
    let arrVoucher = [
        {
            id: 1,
            image: "",
            discount: 20,
            title: "Quoc khanh VN"
        },
        {
            id: 2,
            image: "",
            discount: 30,
            title: "Sinh nhat Thinh Phuc"
        }
    ]

    return (
        <div>
            <div className="font-bold text-[#6f4436]  flex items-center justify-center textright textlg">Lacome Coffee</div>
            <div className="p-2 pt-0 font-bold text-[#be9b7b]  textright textlg">Order</div>

            {
                selectedDrink.map((item) => {
                    return <OrderItem key={item?.id} changeCnt={changeCnt} setChangeCnt={setChangeCnt} items={item}></OrderItem>
                })
            }
            <div className="flex items-center justify-center">
            <div className="w-1/2">
                <label className="text-[#be9b7b] ">Note</label>
                <Textarea className="border-2" onChange={(e)=>writeNote(e)}/>    
            </div>
            </div>


            <div className="flex justify-center items-center">
                <div onClick={handleModal} className="flex justify-center items-center margin-[0 auto] cursor-pointer p-5 border-2 mx-2 text-[vw] max-w-[300px] min-w-[100px] textbase rounded-md ">% Apply Discount Voucher</div>

            </div>
            {
                voucherValue ? <CardVoucher val={voucherValue} /> : ""
            }


            <div className="flex items-center justify-center">
                <div className="w-[25vw]">
                    <div className="text-[vw]">Payment Summary</div>
                    <div className="flex justify-between text-[vw]">
                        <div>
                            <div>Price</div>
                            <div>Discount</div>
                        </div>
                        <div className="flex flex-col items-end">
                            <div>{total()}$</div>
                            <div>{discount()}$</div>
                        </div>

                    </div>
                    <hr className="border-[1.2px] border-black my-5" />
                    <div className="flex justify-between text-[vw]">
                        <div>
                            <div>Total payment</div>
                        </div>
                        <div className="flex flex-col items-end">
                            <div>{total() - discount()}$</div>
                        </div>

                    </div>
                </div>

            </div>

            <div onClick={handleModelOrder} className="flex justify-center items-center pt-5">
                <div className="flex justify-center items-center bg-[#be9b7b] w-[16vw] min-w-[100px] h-[4vw] min-h-[20px] rounded-md cursor-pointer text-[1.7vw]">Confirm Order</div>
            </div>

            {
                checkOrderFinal && (
                    <div className="fixed inset-0 z-[999] grid place-items-center bg-black bg-opacity-60 opacity-100 backdrop-blur-sm">
                        <div className="relative m-4 w-1/4 min-w-[25%] max-w-[25%] rounded-lg bg-white font-sans text-base font-light leading-relaxed text-blue-gray-500 antialiased shadow-2xl">
                            <div className="flex items-center justify-between p-4 font-sans text-2xl antialiased font-semibold leading-snug shrink-0 text-blue-gray-900">
                                <div>
                                    <h1 className="block font-sans text-xl antialiased font-semibold leading-snug tracking-normal text-blue-gray-900">
                                        BILL
                                    </h1>
                                </div>
                                <button onClick={handleModelOrder} className="relative h-8 max-h-[32px] w-8 max-w-[32px] select-none rounded-lg text-center align-middle font-sans text-xs font-medium uppercase text-blue-gray-500 transition-all hover:bg-blue-gray-500/10 active:bg-blue-gray-500/30 disabled:pointer-events-none disabled:opacity-50 disabled:shadow-none" type="button">
                                    <span className="absolute transform -translate-x-1/2 -translate-y-1/2 top-1/2 left-1/2">
                                        <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth="2" className="w-5 h-5">
                                            <path strokeLinecap="round" strokeLinejoin="round" d="M6 18L18 6M6 6l12 12"></path>
                                        </svg>
                                    </span>
                                </button>
                            </div>

                            {/* Content */}
                            <div className="overflow-y-scroll p-4 !px-5 font-sans text-base font-light leading-relaxed text-blue-gray-500 antialiased">
                                {/* Content here */}
                                <div class="mb-6">

                                    {
                                        selectedDrink.map((item) => {
                                            return <BillItem items={item}></BillItem>
                                        })
                                    }
                                    {/* <p
                                        class="block py-3 font-sans text-base antialiased font-semibold leading-relaxed uppercase text-blue-gray-900 opacity-70">
                                        Popular
                                    </p> */}

                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Price:</div>
                                            </div>
                                        </div>

                                        <div className="flex items-center ">
                                            <div className="p-2">{total()}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                                            {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
                                        </div>
                                    </div>

                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Discount:</div>
                                            </div>
                                        </div>

                                        <div className="flex items-center ">
                                            <div className="p-2">{discount()}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                                            {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
                                        </div>
                                    </div>
                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Total:</div>
                                            </div>
                                        </div>

                                        <div className="flex items-center ">
                                            <div className="p-2">{total() - discount()}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                                            {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
                                        </div>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                )
            }

            {/* Modal */}
            {checkModal && (
                <div className="fixed inset-0 z-[999] grid place-items-center bg-black bg-opacity-60 opacity-100 backdrop-blur-sm">
                    <div className="relative m-4 w-1/4 min-w-[25%] max-w-[25%] rounded-lg bg-white font-sans text-base font-light leading-relaxed text-blue-gray-500 antialiased shadow-2xl">
                        <div className="flex items-center justify-between p-4 font-sans text-2xl antialiased font-semibold leading-snug shrink-0 text-blue-gray-900">
                            <div>
                                <h5 className="block font-sans text-xl antialiased font-semibold leading-snug tracking-normal text-blue-gray-900">
                                    Connect a Wallet
                                </h5>
                                <p className="block font-sans text-base antialiased font-light leading-relaxed text-gray-700">
                                    Choose which card you want to connect
                                </p>
                            </div>
                            <button onClick={handleModal} className="relative h-8 max-h-[32px] w-8 max-w-[32px] select-none rounded-lg text-center align-middle font-sans text-xs font-medium uppercase text-blue-gray-500 transition-all hover:bg-blue-gray-500/10 active:bg-blue-gray-500/30 disabled:pointer-events-none disabled:opacity-50 disabled:shadow-none" type="button">
                                <span className="absolute transform -translate-x-1/2 -translate-y-1/2 top-1/2 left-1/2">
                                    <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke="currentColor" strokeWidth="2" className="w-5 h-5">
                                        <path strokeLinecap="round" strokeLinejoin="round" d="M6 18L18 6M6 6l12 12"></path>
                                    </svg>
                                </span>
                            </button>
                        </div>

                        {/* Content */}
                        <div className="overflow-y-scroll p-4 !px-5 font-sans text-base font-light leading-relaxed text-blue-gray-500 antialiased">
                            {/* Content here */}
                            <div class="mb-6">
                                <p
                                    class="block py-3 font-sans text-base antialiased font-semibold leading-relaxed uppercase text-blue-gray-900 opacity-70">
                                    Popular
                                </p>
                                <ul class="flex flex-col gap-1 mt-3 -ml-2">
                                    {
                                        arrVoucher.map((item) => {
                                            return <CardVoucher checkModal={checkModal} handleChose={handleChose} key={item.id} val={item}></CardVoucher>
                                        })
                                    }
                                </ul>
                            </div>

                        </div>

                    </div>
                </div>

            )}
        </div>
    )
}


export default RightOrderPage;
