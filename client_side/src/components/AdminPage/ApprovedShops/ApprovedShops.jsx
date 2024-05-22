import { useDispatch, useSelector } from "react-redux";
import { useState } from "react";
import Modal from 'react-modal';
import { selectShops } from "../../../redux/Reducer/shopSlice";
import { approveShop, suspenseShop } from "../../../redux/Action/shopAction"; // Ensure you import the approveShop action
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const ApprovedShops = () => {
    const dispatch = useDispatch();
    const shops = useSelector(selectShops);
    const [isModalOpen, setIsModalOpen] = useState(false);
    const [selectedShopId, setSelectedShopId] = useState(null);
    const [selectedShopStatus, setSelectedShopStatus] = useState(null);

    const openModal = (shopId, currentStatus) => {
        setSelectedShopId(shopId);
        setSelectedShopStatus(currentStatus);
        setIsModalOpen(true);
    };

    const closeModal = () => {
        setIsModalOpen(false);
        setSelectedShopId(null);
        setSelectedShopStatus(null);
    };

    const handleSuspend = () => {
        if (selectedShopId !== null) {
            dispatch(suspenseShop(selectedShopId, !selectedShopStatus)); // Assuming suspenseShop accepts shopId and new status
            toast.success(`Shop ${selectedShopStatus ? 'unsuspended' : 'suspended'} successfully!`, {
                position: 'top-left',
                autoClose: 5000,
                hideProgressBar: false,
                closeOnClick: true,
                pauseOnHover: true,
                draggable: true,
                progress: undefined,
            });
            closeModal();
        }
    };

    return (
        <div className="relative overflow-x-auto shadow-md sm:rounded-lg">
            <ToastContainer />
            <table className="w-full text-sm text-left rtl:text-right text-gray-500 dark:text-gray-400">
                <thead className="text-xs text-gray-700 uppercase bg-gray-50 dark:bg-gray-700 dark:text-gray-400">
                    <tr>
                        <th scope="col" className="px-6 py-3">
                            Branch name
                        </th>
                        <th scope="col" className="px-6 py-3">
                            Address
                        </th>
                        <th scope="col" className="px-6 py-3">
                            Owner name
                        </th>
                        <th scope="col" className="px-6 py-3">
                            Date created
                        </th>
                        <th scope="col" className="px-6 py-3">
                            Action
                        </th>
                    </tr>
                </thead>
                <tbody>
                    {shops?.filter((item) => item?.isApproved)?.map((item) => (
                        <tr key={item.id} className="odd:bg-white odd:dark:bg-gray-900 even:bg-gray-50 even:dark:bg-gray-800 border-b dark:border-gray-700">
                            <th scope="row" className="px-6 py-4 font-medium text-gray-900 whitespace-nowrap dark:text-white">
                                {item?.name}
                            </th>
                            <td className="px-6 py-4">
                                {item?.address}
                            </td>
                            <td className="px-6 py-4">
                                {item?.ownerFullName}
                            </td>
                            <td className="px-6 py-4">
                                {item?.formattedDateCreated}
                            </td>
                            <td className="px-6 py-4">
                                <label className="inline-flex items-center cursor-pointer">
                                    <input 
                                        type="checkbox" 
                                        value="" 
                                        className="sr-only peer"
                                        checked={!item.isSuspended}
                                        onChange={() => openModal(item.id, item.isSuspended)}
                                    />
                                    <div className={`relative w-14 h-7 peer-focus:outline-none peer-focus:ring-4 peer-focus:ring-blue-300 dark:peer-focus:ring-blue-800 rounded-full peer dark:bg-gray-700 ${item.isSuspended ? 'bg-red-600' : 'bg-gray-200'} peer-checked:after:translate-x-full rtl:peer-checked:after:-translate-x-full peer-checked:after:border-white after:content-[''] after:absolute after:top-0.5 ${item.isSuspended ?  'after:start-[calc(100%-1.65rem)]': 'after:start-[calc(100%-4.8rem)]' } after:bg-white after:border-gray-300 after:border after:rounded-full after:h-6 after:w-6 after:transition-all dark:border-gray-600`}></div>
                                    <span className="ms-3 text-sm font-medium text-gray-900 dark:text-gray-300">Large toggle</span>
                                </label>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
            <Modal
                isOpen={isModalOpen}
                onRequestClose={closeModal}
                contentLabel="Confirm Suspension"
                ariaHideApp={false}
                className="modal-content"
                overlayClassName="modal-overlay"
            >
                <div className="p-6">
                    <h2 className="text-lg font-bold mb-4">Are you sure you want to {selectedShopStatus ? 'UNSUSPEN' : 'SUSPEN'} this shop?</h2>
                    <div className="flex justify-end gap-4">
                        <button
                            onClick={closeModal}
                            className="bg-gray-200 text-gray-700 text-sm font-[500] pt-1 pb-1 pl-3 pr-3 rounded-md"
                        >
                            Cancel
                        </button>
                        <button
                            onClick={handleSuspend}
                            className="bg-green-400 text-white text-sm font-[500] pt-1 pb-1 pl-3 pr-3 rounded-md"
                        >
                            Agree
                        </button>
                    </div>
                </div>
            </Modal>
        </div>
    );
};

export default ApprovedShops;
