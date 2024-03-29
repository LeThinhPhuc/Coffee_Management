import React, { useState } from "react";
import MenuItem from "./MenuItem";
import MenuModel from "./MenuModel";
import TemplateData from "./TemplateData";

const LeftMenu = () => {
    const [showModal, setShowModal] = useState(false);
    const [isEditing, setIsEditing] = useState(false);

    const handleClickEdit = () => {
        setIsEditing((isEditing) => !isEditing);
        console.log(isEditing);
    };

    const handleShowModel = () => {
        setShowModal(true);
    };

    const handleCloseModel = () => {
        setShowModal(false);
    };

    const handleDeleteItem = () => {
        console.log("Deleted");
    };

    return (
        //
        <div className="container mx-auto mt-20 p-4  rounded-xl shadow-lg bg-clip-border">
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
                        onClick={(e) => setShowModal(true)}
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
            <div className=" gap-x-4 gap-y-8 grid grid-cols-6 rounded-xl">
                {TemplateData &&
                    TemplateData.map((item, index) => {
                        return (
                            <MenuItem
                                key={index}
                                isEditing={isEditing}
                                handleShowModel={handleShowModel}
                                handleDeleteItem={handleDeleteItem}
                                image={item.image}
                                name={item.name}
                                price={item.price}
                                desc={item.desc}
                            ></MenuItem>
                        );
                    })}
            </div>

            {/* Model */}
            {showModal && (
                <MenuModel handleCloseModel={handleCloseModel}></MenuModel>
            )}
        </div>
    );
};

export default LeftMenu;
