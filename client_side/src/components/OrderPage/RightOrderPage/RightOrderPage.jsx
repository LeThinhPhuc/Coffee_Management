import { useContext, useState } from "react";
import Modal from "../Modal/Modal";
import OrderItem from "./OrderItem/OrderItem";
import '../../../App.css'
import { MenuContext } from "../../../context/MenuContext";
import CardVoucher from "./CardVoucher/CardVoucher";
const RightOrderPage = () => {
    const { selectedDrink, addSelectedDrink } = useContext(MenuContext)
    const [checkModal, setCheckModal] = useState(false);

    const handleModal = () => {
        setCheckModal(!checkModal);
    }


    let arrVoucher=[
        {
            id:1,
            image:"",
            discount:20,
            title:"Quoc khanh VN"
        },
        {
            id:2,
            image:"",
            discount:30,
            title:"Sinh nhat Thinh Phuc"
        }
    ]

    return (
        <div>
            <div className="font-bold text-[#6f4436]  flex items-center justify-center textright textlg">Lacome Coffee</div>
            <div className="p-2 pt-0 font-bold text-[#be9b7b]  textright textlg">Order</div>

            {
                selectedDrink.map((item) => {
                    return <OrderItem items={item}></OrderItem>
                })
            }
            <div className="flex justify-center items-center">
                <div onClick={handleModal} className="flex justify-center items-center margin-[0 auto] cursor-pointer p-5 border-2 mx-2 text-[vw] max-w-[300px] min-w-[100px] textbase rounded-md ">% Apply Discount Voucher</div>

            </div>

            <div className="flex items-center justify-center">
                <div className="w-[25vw]">
                    <div className="text-[vw]">Payment Summary</div>
                    <div className="flex justify-between text-[vw]">
                        <div>
                            <div>Price</div>
                            <div>Discount</div>
                        </div>
                        <div className="flex flex-col items-end">
                            <div>1000$</div>
                            <div>0$</div>
                        </div>

                    </div>
                    <hr className="border-[1.2px] border-black my-5" />
                    <div className="flex justify-between text-[vw]">
                        <div>
                            <div>Total payment</div>
                        </div>
                        <div className="flex flex-col items-end">
                            <div>1000$</div>
                        </div>

                    </div>
                </div>

            </div>

            <div className="flex justify-center items-center pt-5">
                <div className="flex justify-center items-center bg-[#be9b7b] w-[16vw] min-w-[100px] h-[4vw] min-h-[20px] rounded-md cursor-pointer text-[1.7vw]">Confirm Order</div>

            </div>

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
                                    {/* <button role="menuitem"
                                        class="mb-4 flex w-full cursor-pointer select-none items-center justify-center gap-3 rounded-md px-3 !py-4 pt-[9px] pb-2 text-start leading-tight shadow-md outline-none transition-all hover:bg-blue-gray-50 hover:bg-opacity-80 hover:text-blue-gray-900 focus:bg-blue-gray-50 focus:bg-opacity-80 focus:text-blue-gray-900 active:bg-blue-gray-50 active:bg-opacity-80 active:text-blue-gray-900">
                                        <img src="https://docs.material-tailwind.com/icons/metamask.svg" alt="metamast" class="w-6 h-6" />
                                        <h6
                                            class="block font-sans text-base antialiased font-semibold leading-relaxed tracking-normal uppercase text-blue-gray-900">
                                            Connect with MetaMask
                                        </h6>
                                    </button>
                                    <button role="menuitem"
                                        class="mb-1 flex w-full cursor-pointer select-none items-center justify-center gap-3 rounded-md px-3 !py-4 pt-[9px] pb-2 text-start leading-tight shadow-md outline-none transition-all hover:bg-blue-gray-50 hover:bg-opacity-80 hover:text-blue-gray-900 focus:bg-blue-gray-50 focus:bg-opacity-80 focus:text-blue-gray-900 active:bg-blue-gray-50 active:bg-opacity-80 active:text-blue-gray-900">
                                        <img src="https://docs.material-tailwind.com/icons/coinbase.svg" alt="metamast"
                                            class="w-6 h-6 rounded-md" />
                                        <h6
                                            class="block font-sans text-base antialiased font-semibold leading-relaxed tracking-normal uppercase text-blue-gray-900">
                                            Connect with Coinbase
                                        </h6>
                                    </button> */}
                                    {
                                        arrVoucher.map((item)=>{
                                            return <CardVoucher key={item.id} val={item}></CardVoucher>
                                        })
                                    }
                                    {/* <CardVoucher></CardVoucher>
                                    <CardVoucher></CardVoucher> */}





                                    
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
