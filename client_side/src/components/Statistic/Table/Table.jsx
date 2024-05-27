import { useEffect, useState } from "react";
import { fetchOrders } from "../../../redux/Action/orderAction";
import { Pagination } from "./Pagination";
import { useSelector, useDispatch } from 'react-redux'
import ordeSlice from "../../../redux/Reducer/orderSlice";
import selectOrders from "../../../redux/Reducer/orderSlice";
import { ListItem } from "@material-tailwind/react";
import Bill from "./Bill";
import { formatCurrency } from "../../../utils/utils";

const Table = () => {
    const dispatch = useDispatch();
    const orders = useSelector((state) => state.order.orders);
    const [checkOrderFinal, setCheckOrderFinal] = useState(false);
    const [drinks, setDrinks] = useState([]);
    const [total, setTotal] = useState(0);
    const [currentPage, setCurrentPage] = useState(1); 

    const itemsPerPage = 10;
    const totalOrders = orders.length;
    const totalPages = Math.ceil(totalOrders / itemsPerPage);

    const startIndex = (currentPage - 1) * itemsPerPage;
    const endIndex = startIndex + itemsPerPage;
    const currentOrders = orders.slice(startIndex, endIndex);

    const handlePageChange = (page) => {
        setCurrentPage(page);
    };

    const handleCloseModal = () => {
        setCheckOrderFinal(!checkOrderFinal);
    };

    const formatDate = (dateString) => {
        const date = new Date(dateString);
        const day = String(date.getDate()).padStart(2, '0');
        const month = String(date.getMonth() + 1).padStart(2, '0');
        const year = date.getFullYear();
        return `${day}-${month}-${year}`;
    };

    return (
        <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 xl:col-span-2">
            <div className="mb-4 flex items-center justify-between">
                <div>
                    <h3 className="text-xl font-bold text-gray-900 mb-2">Lịch Sử Hóa Đơn</h3>
                </div>
                <div className="flex-shrink-0">
                    <a href="#" className="text-sm font-medium text-cyan-600 hover:bg-gray-100 rounded-lg p-2">View all</a>
                </div>
            </div>
            <div className="flex flex-col mt-8">
                <div className="overflow-x-auto rounded-lg border-2">
                    <div className="align-middle inline-block min-w-full">
                        <div className="shadow overflow-hidden sm:rounded-lg">
                            <table className="min-w-full divide-y divide-gray-200">
                                <thead className="bg-gray-50">
                                    <tr>
                                        <th scope="col" className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">ID</th>
                                        <th scope="col" className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Ngày lập</th>
                                        <th scope="col" className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Số tiền</th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody className="bg-white">
                                    {currentOrders?.map((bill) => (
                                        <tr key={bill.orderId}>
                                            <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-900">{bill.orderId}</td>
                                            <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-500">{formatDate(bill.orderDate)}</td>
                                            <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-900">{formatCurrency(bill.total)}</td>
                                            <td>
                                                <a 
                                                  onClick={() => {
                                                      setCheckOrderFinal(!checkOrderFinal); 
                                                      setDrinks(bill.items); 
                                                      setTotal(bill.total); 
                                                      console.log(bill.items);
                                                  }}
                                                  href="#_"
                                                  className="inline-flex items-center justify-center px-2 py-1 text-sm font-normal leading-6 text-gray-600 whitespace-no-wrap bg-white border border-gray-200 rounded-md shadow-sm hover:bg-gray-50 focus:outline-none focus:shadow-none"
                                                >
                                                    Chi tiết hóa đơn
                                                </a>
                                            </td>
                                        </tr>
                                    ))}
                                </tbody>
                            </table>
                        </div>
                    </div>
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
                                    {drinks?.map((item) => (
                                        <Bill key={item.id} items={item} />
                                    ))}
                                    <div className="flex justify-between pr-2 pl-2 pb-3">
                                        <div className="flex items-center justify-center">
                                            <div className="pl-2">
                                                <div className="font-bold text-[#6f4436]">Total:</div>
                                            </div>
                                        </div>
                                        <div className="flex items-center ">
                                            <div className="p-2">{formatCurrency(total)}</div> 
                                            {/* <button onClick={()=>{deleteOutSelected(items)}} className="font-bold text-red-500 pl-2 text-[2vw]">x</button> */}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                )}
                <div className="my-3 flex justify-center">
                    <Pagination 
                      totalPages={totalPages}
                      currentPage={currentPage}
                      onPageChange={handlePageChange} 
                    />
                </div>
            </div>
        </div>
    );
};

export default Table;
