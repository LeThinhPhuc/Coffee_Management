import React, { useEffect, useState } from "react";
import MenuItem from "../MenuItem";
import MenuModel from "../MenuModel";
import TemplateDataMenu from "./TemplateDataMenu";
import axios from "axios";

const ManageMenu = () => {
    const [data, setData] = useState(null);
    const [showModal, setShowModal] = useState(false);
    const [isEditing, setIsEditing] = useState(false);
    const [item, setItem] = useState({
        title: null,
        image: null,
        name: null,
        price: null,
        desc: null,
    });

    useEffect(() => {
        const fetchData = async () => {
            try {
                const response = await axios.get(
                    "http://localhost:5146/api/Drink/getallgrouped"
                );
                setData(response.data);
            } catch (error) {
                console.log("Error: " + error);
            }
            //   finally {
            //   }
        };

        fetchData();
    }, []);

    const handleClickEdit = () => {
        setIsEditing((isEditing) => !isEditing);
    };

    const handleShowModel = () => {
        setShowModal(true);
    };

    const handleCloseModel = () => {
        setShowModal(false);
    };

    const handleDeleteItem = (category, index) => {
        console.log(`Deleted item at [${index}] of [${category}]`);
    };

    return (
        //
        <div className="container mx-auto mt-20 p-[75px] pt-0  rounded-xl shadow-lg bg-clip-border">
            {/* Button */}
            <div className="flex ml-[7px] gap-5 mt-4 mb-8">
                <div className="">
                    <button
                        // focus:opacity-[0.85]
                        // focus:scale-105 focus:shadow-none
                        className="text-base align-middle select-none font-sans font-bold text-center bg-[#10b981] text-white  transition-all
                    disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none  py-3 px-6 rounded-lg
                    shadow-gray-900/10 hover:shadow-gray-900/20  active:opacity-[0.85] active:shadow-none block w-full bg-blue-gray-900/10 text-blue-gray-900 shadow-none hover:scale-105 hover:shadow-none  active:scale-100"
                        type="button"
                        onClick={(e) => {
                            setItem((item) => ({
                                image: null,
                                name: null,
                                price: null,
                                desc: null,
                                title: "Thêm sản phẩm",
                            }));
                            setShowModal(true);
                        }}
                    >
                        Thêm
                    </button>
                </div>

                <div className="">
                    <button
                        className="text-base align-middle select-none font-sans font-bold text-center bg-[#ffa400] text-black  transition-all
                    disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none  py-3 px-6 rounded-lg
                    shadow-gray-900/10 hover:shadow-gray-900/20  active:opacity-[0.85] active:shadow-none block w-full bg-blue-gray-900/10 text-blue-gray-900 shadow-none hover:scale-105 hover:shadow-none  active:scale-100"
                        type="button"
                        onClick={handleClickEdit}
                    >
                        Chỉnh sửa
                    </button>
                </div>
            </div>

            {/* Item */}
            {TemplateDataMenu &&
                TemplateData.map((data, index) => {
                    return (
                        <div key={index} className="mb-[50px]">
                            <h3 className="ml-[7px] mb-4  block text-3xl antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                                {data.category}
                            </h3>

                            <div className=" gap-x-6 gap-y-10 grid grid-cols-6 rounded-xl">
                                {data.items.map((item, index) => {
                                    return (
                                        <MenuItem
                                            key={index}
                                            id={index}
                                            category={data.category}
                                            isEditing={isEditing}
                                            setItem={setItem}
                                            handleShowModel={handleShowModel}
                                            handleDeleteItem={handleDeleteItem}
                                            item={item}
                                        ></MenuItem>
                                    );
                                })}
                            </div>
                        </div>
                    );
                })}

            {/* Model */}
            {showModal && (
                <MenuModel
                    handleCloseModel={handleCloseModel}
                    item={item}
                    setItem={setItem}
                ></MenuModel>
            )}
        </div>
    );
};

export default ManageMenu;
