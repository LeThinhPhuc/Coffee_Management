import React from "react";
import "./styles.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
    faChampagneGlasses,
    faPen,
    faTrash,
} from "@fortawesome/free-solid-svg-icons";

const MenuItem = (props) => {
    return (
        <div className="relative flex flex-col justify-start mx-auto p-[12px] gap-2 text-gray-700 bgr bg shadow-lg bg-clip-border rounded-xl ">
            {/* Card-Image */}
            <div className="relative w-full max-w-[200px] min-h-[200px] max-h-[200px]  overflow-hidden text-white shadow-lg bg-clip-border rounded-xl bg-blue-gray-500 shadow-blue-gray-500/40">
                <img
                    src={props.item.image}
                    alt="card-image"
                    className="object-cover  size-full "
                />
            </div>

            {/* Card-Info */}
            <div className="">
                <h5 className="min-h-[55px] block text-lg antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                    {props.item.name}
                </h5>
                <p className="font-bold text-[#854442] mb-2">
                    {props.item.price}
                </p>
                <p className="block  text-base antialiased font-normal leading-relaxed text-inherit">
                    {props.item.desc}
                </p>
            </div>

            {/* Edit - Delete */}
            <div
                className={`transition-all absolute text-xl  -top-[18px] -right-[5px] flex gap-2  item-options ${
                    props.isEditing ? "show" : ""
                }`}
            >
                <p
                    className="cursor-pointer size-[20px] text-[#ffa400] rounded-full hover:scale-125 transition-all"
                    onClick={() => {
                        props.setItem((item) => ({
                            ...item,
                            title: "Sửa sản phẩm",
                            name: props.item.name,
                            price: props.item.price,
                            desc: props.item.desc,
                            image: props.item.image,
                        }));
                        props.handleShowModel();
                    }}
                >
                    <FontAwesomeIcon icon={faPen} />
                </p>
                <p
                    className="cursor-pointer size-[20px] text-[#e74c3c] rounded-full hover:scale-125 transition-all"
                    onClick={() => {
                        props.handleDeleteItem(props.category, props.id);
                    }}
                >
                    <FontAwesomeIcon icon={faTrash} />
                </p>
            </div>
        </div>
    );
};

export default MenuItem;
