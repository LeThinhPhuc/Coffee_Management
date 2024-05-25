import { useEffect, useState } from "react";
import { fetchOrders } from "../../../redux/Action/orderAction";
import { Pagination } from "./Pagination";
import { useSelector, useDispatch } from 'react-redux'
import ordeSlice from "../../../redux/Reducer/orderSlice";
import selectOrders from "../../../redux/Reducer/orderSlice";
import { ListItem } from "@material-tailwind/react";
const Table = () => {

    const dispatch = useDispatch();
    const orders = useSelector((state) => state.order.orders)

    // Hàm định dạng ngày thành dd-mm-yyyy
    const formatDate = (dateString) => {
        const date = new Date(dateString);
        const day = String(date.getDate()).padStart(2, '0');
        const month = String(date.getMonth() + 1).padStart(2, '0');
        const year = date.getFullYear();
        return `${day}-${month}-${year}`;
    };

    const itemsPerPage = 3;//số phần tử trên 1 trang (thay đổi số item 1 trang ở đầy nè)

    const [currentPage, setCurrentPage] = useState(1); // Trang hiện tại, mặc định là 1
    const totalOrders = orders.length; // Tổng số orders
    const totalPages = Math.ceil(totalOrders / itemsPerPage); // Số trang

    const startIndex = (currentPage - 1) * itemsPerPage; //ví trí bắt đầu cắt (ví dụ lấy phần tử ở trang 5 thì trừ tổng item ở 4 trang trước)
    const endIndex = startIndex + itemsPerPage; //vị trí cuối

    const currentOrders = orders.slice(startIndex, endIndex);

    const handlePageChange = (page) => {
        setCurrentPage(page);
    };

    return (
        <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:p-8 xl:col-span-2">
            <div className="mb-4 flex items-center justify-between">
                <div>
                    <h3 className="text-xl font-bold text-gray-900 mb-2">
                        Lịch Sử Hóa Đơn
                    </h3>
                </div>
                <div className="flex-shrink-0">
                    <a
                        href="#"
                        className="text-sm font-medium text-cyan-600 hover:bg-gray-100 rounded-lg p-2"
                    >
                        View all
                    </a>
                </div>
            </div>
            <div className="flex flex-col mt-8">
                <div className="overflow-x-auto rounded-lg border-2">
                    <div className="align-middle inline-block min-w-full">
                        <div className="shadow overflow-hidden sm:rounded-lg">
                            <table className="min-w-full divide-y divide-gray-200">
                                <thead className="bg-gray-50">
                                    <tr>
                                        <th
                                            scope="col"
                                            className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                                        >
                                            ID
                                        </th>
                                        <th
                                            scope="col"
                                            className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                                        >
                                            Ngày lập
                                        </th>
                                        <th
                                            scope="col"
                                            className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                                        >
                                            Số tiền
                                        </th>
                                        <th></th>
                                    </tr>
                                </thead>
                                <tbody className="bg-white">
                                    {currentOrders?.map((bill) => (
                                        <tr key={bill.orderId}>
                                            <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-900">
                                                {bill.orderId}
                                            </td>
                                            <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-500">
                                                {formatDate(bill.orderDate)}
                                            </td>
                                            <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-900">
                                                {bill.total} VNĐ
                                            </td>
                                            <td>
                                                <a
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
                <div className="my-3 flex justify-center ">
                    <Pagination totalPages={totalPages}
                                currentPage={currentPage}
                                onPageChange={handlePageChange} />
                </div>
            </div>
        </div>
    );
};

export default Table;
