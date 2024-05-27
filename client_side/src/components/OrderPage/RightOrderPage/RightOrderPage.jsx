import { useContext, useEffect, useState } from "react";
import Modal from "../Modal/Modal";
import OrderItem from "./OrderItem/OrderItem";
import '../../../App.css';
import { Textarea, Input } from '@material-tailwind/react';
import { MenuContext } from "../../../context/MenuContext";
import CardVoucher from "./CardVoucher/CardVoucher";
import BillItem from "./BillItem/BillItem";
import { useDispatch, useSelector } from 'react-redux';
import { addOrder, fetchOrders } from "../../../redux/Action/orderAction";
import { selectVouchers } from "../../../redux/Reducer/voucherSlice";
import { orderError } from "../../../redux/Reducer/orderSlice";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import { fetchIngredients } from "../../../redux/Action/ingredientAction";
import orderService from "../../../services/orderService";
import { formatCurrency } from "../../../utils/utils";

const RightOrderPage = () => {
    const { selectedDrink, addSelectedDrink, checkModalVoucher, setCheckModalVoucher, voucherValue, clearSelected, setVoucherValue } = useContext(MenuContext);
    const [checkModal, setCheckModal] = useState(false);
    const [checkOrderFinal, setCheckOrderFinal] = useState(false);
    const [changeCnt, setChangeCnt] = useState(0);
    const [note, setNote] = useState("");
    const dispatch = useDispatch();
    const vouchers = useSelector(selectVouchers);
    const orderFail = useSelector(orderError);
    const store = JSON.parse(localStorage.getItem("user")).shops[0]

    const handleModal = () => {
        setCheckModal(!checkModal);
    };

    const handleCloseModal = () => {
        setCheckOrderFinal(!checkOrderFinal);
        setVoucherValue();
        clearSelected();
    };

    const handleModelOrder = async () => {
        if (selectedDrink.length > 0) {
            console.log("bill order: ", { selectedDrink: selectedDrink, total: total() - discount() });
            const data = {
                userId: JSON.parse(localStorage.getItem("user")).user.idToUpdate,
                total: total() - discount(),
                orderItems: selectedDrink
            };
            // dispatch(addOrder(data));

            try {
                const res = await orderService.postOrder(data);
                console.log("loi", res?.message)
                dispatch(fetchIngredients())
                dispatch(fetchOrders())
                setCheckOrderFinal(!checkOrderFinal)
            } catch (error) {
                toast.error('Ingredient not enough', {
                    position: "bottom-left",
                    autoClose: 5000,
                    hideProgressBar: false,
                    closeOnClick: true,
                    pauseOnHover: true,
                    draggable: true,
                    progress: undefined,
                });
                console.error('Error placing order:', error);
            }
        } else {
            alert("Please select a drink!");
        }
    };

    const handleChose = (tmp) => {
        setCheckModal(tmp);
    };

    useEffect(() => {
        total();
        discount();
    }, [changeCnt]);

    const total = () => {
        let sum = 0;
        if (selectedDrink) {
            for (let i = 0; i < selectedDrink.length; i++) {
                sum += (selectedDrink[i].price * selectedDrink[i].quantity);
            }
        }
        return sum;
    };

    const writeNote = (e) => {
        console.log(e.target.value);
        setNote(e.target.value);
    };

    const discount = () => {
        let to = total();
        if (voucherValue) {
            return to * voucherValue.discountPercent / 100;
        } else {
            return 0;
        }
    };
    var today = new Date();
    return (
        <div>
            <ToastContainer />
            <div className="font-bold text-[#6f4436]  flex items-center justify-center textright textlg">{JSON.parse(localStorage.getItem("user"))?.shops[0]?.name} Coffee</div>
            <div className="p-2 pt-0 font-bold text-[#be9b7b]  textright textlg">Order</div>

            {
                selectedDrink.map((item) => {
                    return <OrderItem key={item?.id} changeCnt={changeCnt} setChangeCnt={setChangeCnt} items={item}></OrderItem>
                })
            }



            <div className="flex flex-col items-center space-y-8">
                <div onClick={handleModal} className="flex justify-center items-center cursor-pointer p-4 border-2 border-[#be9b7b] text-[#be9b7b] hover:bg-[#be9b7b] hover:text-white transition duration-300 mx-auto text-lg max-w-xs min-w-[100px] rounded-md">
                    % Apply Discount Voucher
                </div>

                {voucherValue ? <CardVoucher val={voucherValue} /> : null}

                <div className="flex items-center justify-center w-full">
                    <div className="w-[90%] max-w-lg bg-white p-6 rounded-lg shadow-md">
                        <div className="text-2xl font-semibold mb-4 text-center">Payment Summary</div>
                        <div className="flex justify-between text-lg mb-2">
                            <div>
                                <div className="mb-1">Price</div>
                                <div>Discount</div>
                            </div>
                            <div className="flex flex-col items-end">
                                <div className="mb-1">{formatCurrency(total())}</div>
                                <div>{formatCurrency(discount())}</div>
                            </div>
                        </div>
                        <hr className="border-gray-300 my-4" />
                        <div className="flex justify-between text-lg font-semibold">
                            <div>Total payment</div>
                            <div className="flex items-end">
                                <div>{formatCurrency(total() - discount())}</div>
                            </div>
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
                                    <div className="flex flex-col items-center text-center">
                                        <div className="font-bold text-[#6f4436] textxl">
                                            {store?.name} Coffee
                                        </div>
                                      
                                    </div>
                                <button onClick={handleCloseModal} className="relative h-8 max-h-[32px] w-8 max-w-[32px] select-none rounded-lg text-center align-middle font-sans text-xs font-medium uppercase text-blue-gray-500 transition-all hover:bg-blue-gray-500/10 active:bg-blue-gray-500/30 disabled:pointer-events-none disabled:opacity-50 disabled:shadow-none" type="button">
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

                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Price:</div>
                                            </div>
                                        </div>

                                        <div className="flex items-center ">
                                            <div className="p-2">{formatCurrency(total())}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                                        </div>
                                    </div>

                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Discount:</div>
                                            </div>
                                        </div>

                                        <div className="flex items-center ">
                                            <div className="p-2">{formatCurrency(discount())}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                                        </div>
                                    </div>
                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Total:</div>
                                            </div>
                                        </div>

                                        <div className="flex items-center ">
                                            <div className="p-2">{formatCurrency(total() - discount())}</div> {/* Sử dụng cnt để hiển thị giá trị soluong */}
                                            {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
                                        </div>
                                    </div>
                                    <p className="text-sm text-gray-500">
                                            Address: {store?.address}
                                        </p>
                                        <p className="text-sm text-gray-500">Bill created at: {today.getDate() + '-' + (today.getMonth() + 1) + '-' + today.getFullYear() + " at " + today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds()}</p>
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
                                    Choose a Voucher
                                </h5>
                                <p className="block font-sans text-base antialiased font-light leading-relaxed text-gray-700">
                                    Choose which Voucher you want to discount
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
                                        vouchers.map((item) => {
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
