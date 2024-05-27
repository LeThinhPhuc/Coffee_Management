import React, { useState } from 'react';
import Modal from 'react-modal';
import { useDispatch, useSelector } from 'react-redux';
import { selectShops } from '../../../redux/Reducer/shopSlice';
import { approveShop } from '../../../redux/Action/shopAction';
import { toast } from 'react-toastify';
import "./WaitingShops.css"

const WaitingShops = () => {
    const user = localStorage.getItem("user");
    const parsedUser = JSON.parse(user);
    const dispatch = useDispatch();
    const shops = useSelector(selectShops);
    const [isModalOpen, setIsModalOpen] = useState(false);
    const [selectedShopId, setSelectedShopId] = useState(null);

    const openModal = (shopId) => {
        setSelectedShopId(shopId);
        setIsModalOpen(true);
    };

    const closeModal = () => {
        setIsModalOpen(false);
        setSelectedShopId(null);
    };

    const handleApprove = () => {
        if (selectedShopId) {
            dispatch(approveShop(selectedShopId));
            toast.success('Approved successfully!', {
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
        <div>
            {shops?.filter((item) => item.isApproved == false)?.map((item) => {
                return (
                    <div key={item?.id} className="mt-3 cursor-pointer outline-cyan-500 outline-1 bg-[white] outline flex p-6 drop-shadow-[0px_8px_30px_#DEE6F1] border-t first:border-b-[#C5CEE0] last:border-b hover:border-transparent hover:border-0 hover:rounded-2xl hover:shadow-[0px_8px_30px_#DEE6F1] transition-all duration-200">
                        <div className="w-full flex flex-row justify-between items-center">
                            <div className="w-4/5">
                                <div className="text-lg leading-5 md:leading-6 md:text-xl font-semibold mb-2">
                                    <span className="text-[#6f4436]">{item?.name.toUpperCase()}</span> - {item?.address}
                                </div>
                                <div className="text-sm text-gray-500">{item?.formattedDateCreated}</div>
                            </div>
                            <div>
                                <div className="flex gap-2">
                                    <button
                                        onClick={() => openModal(item?.id)}
                                        className="bg-[#dee6f1] text-sky-500 text-sm font-[500] pt-1 pb-1 pl-3 pr-3 rounded-md whitespace-nowrap"
                                    >
                                        Approve
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                );
            })}
            {(shops && shops.filter((item) => !item.isApproved).length === 0) && (
                <div className='pt-5 pl-10 font-bold text-lg text-rose-700'>There are currently no stores pending approval !</div>
            )}


            <Modal
                isOpen={isModalOpen}
                onRequestClose={closeModal}
                contentLabel="Confirm Approval"
                ariaHideApp={false}
                className="modal-content"
                overlayClassName="modal-overlay"
            >
                <div className="p-6">
                    <h2 className="text-lg font-bold mb-4">Are you sure you want to approve this shop ?</h2>
                    <p className="mb-6">The owner will start to run business !</p>
                    <div className="flex justify-end gap-4">
                        <button
                            onClick={closeModal}
                            className="bg-gray-200 text-gray-700 text-sm font-[500] pt-1 pb-1 pl-3 pr-3 rounded-md"
                        >
                            Cancel
                        </button>
                        <button
                            onClick={handleApprove}
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

export default WaitingShops;
