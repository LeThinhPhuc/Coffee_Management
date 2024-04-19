import React, { useState } from "react";
import "./styles.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
// import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";

import {
    faPen,
    faTrash,
    faCirclePlus,
} from "@fortawesome/free-solid-svg-icons";

//! Card
const MenuItem = (props) => {
    //! Lấy Item được truyền vào, để có thể sửa.
    const [propsItem, setPropsItem] = useState(props.item);

    //! Theo như templateData thì nếu không có "desc" thì sẽ là card của nguyên liệu
    if (!propsItem.desc) {
        const desc = propsItem.entryDate + " - " + propsItem.expiryDate;

        setPropsItem({
            //! ... là destructuring object, bung hết các field của object
            ...props.item,

            //! field chưa có -> thêm, có -> update
            desc: desc,
            info: propsItem.quantity,
        });
    }
    // console.log(propsItem);

    return (
        <div className="relative flex flex-col justify-start mx-auto p-[12px] gap-2 text-gray-700 bgr bg shadow-2xl bg-clip-border rounded-xl ">
            {/*//! Card-Image */}
            <div className="relative w-full max-w-[200px] min-h-[200px] max-h-[200px]  overflow-hidden text-white shadow-lg bg-clip-border rounded-xl bg-blue-gray-500 shadow-blue-gray-500/40">
                <img
                    src={propsItem.image}
                    alt="card-image"
                    className="object-cover  size-full "
                />
            </div>

            {/*//! Card-Info */}
            <div className="">
                <h5
                    className={`${
                        propsItem.price && "min-h-[55px]"
                    } block text-lg antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900`}
                >
                    {propsItem.name}
                </h5>
                <p className="font-bold text-[#854442] mb-2">
                    {propsItem.quantity && "Số lượng: "}
                    {propsItem.info || propsItem.price}
                </p>
                <p className="block  text-base antialiased font-medium leading-relaxed text-inherit">
                    {propsItem.desc}
                </p>
            </div>

            {/*//! Edit - Delete */}
            <div
                className={`transition-all absolute text-xl  -top-[18px] -right-[5px] flex gap-2  item-options ${
                    props.isEditing ? "show" : ""
                }`}
            >
                {/*//! Add quantity for Ingredient */}
                {props.type != "menu" && (
                    <p
                        className="cursor-pointer size-[20px] text-[#10B981] rounded-full hover:scale-125 transition-all"
                        onClick={() => {
                            props.handleAddIngredient(
                                props.id,
                                propsItem.name,
                                props.category
                            );
                        }}
                    >
                        <FontAwesomeIcon icon={faCirclePlus} />
                    </p>
                )}

                {/*//!Edit */}
                <p
                    className="cursor-pointer size-[20px] text-[#ffa400] rounded-full hover:scale-125 transition-all"
                    onClick={() => {
                        props.setItem((item) => ({
                            ...propsItem,
                            title: "Sửa đối tượng",
                            name: propsItem.name,
                            info: propsItem.info || propsItem.price,
                            desc: propsItem.desc,
                            image: propsItem.image,
                        }));
                        props.handleShowModel();
                    }}
                >
                    <FontAwesomeIcon icon={faPen} />
                </p>

                {/*///! Delete */}
                <p
                    className="cursor-pointer size-[20px] text-[#e74c3c] rounded-full hover:scale-125 transition-all"
                    onClick={() => {
                        props.handleDeleteItem(props.id, props.category);
                    }}
                >
                    <FontAwesomeIcon icon={faTrash} />
                </p>
            </div>
        </div>
    );
};

export default MenuItem;
