import React from "react";
import "./styles.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faPen, faTrash } from "@fortawesome/free-solid-svg-icons";

const MenuItem = (props) => {
    return (
        <div
            // key={props.key}
            // justify-start
            className="relative flex flex-col justify-between mx-auto p-[12px] gap-2 text-gray-700 bgr bg shadow-lg bg-clip-border rounded-xl "
        >
            <div className="relative w-full max-w-[200px] min-h-[200px] max-h-[200px]  overflow-hidden text-white shadow-lg bg-clip-border rounded-xl bg-blue-gray-500 shadow-blue-gray-500/40">
                <img
                    src={props.image}
                    alt="card-image"
                    className="object-cover  size-full "
                />
            </div>
            <div className="">
                <h5 className="block text-xl antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                    {props.name}
                </h5>
                <p className="font-bold text-[#854442] mb-2">{props.price}</p>
                <p className="block  text-base antialiased font-normal leading-relaxed text-inherit">
                    {props.desc}
                </p>
            </div>

            <div
                className={`transition-all absolute text-xl  -top-[18px] -right-[5px] flex gap-2  item-options ${
                    props.isEditing ? "show" : ""
                }`}
            >
                <p
                    className="cursor-pointer size-[20px] text-[#ffa400] rounded-full hover:scale-125 transition-all"
                    onClick={props.handleShowModel}
                >
                    <FontAwesomeIcon icon={faPen} />
                </p>
                <p
                    className="cursor-pointer size-[20px] text-[#e74c3c] rounded-full hover:scale-125 transition-all"
                    onClick={props.handleDeleteItem}
                >
                    <FontAwesomeIcon icon={faTrash} />
                </p>
            </div>

            {/* <div className="">
                <button
                    className="align-middle select-none  font-bold text-center bg-[#BE9B7B] text-black  transition-all 
                    disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 px-6 rounded-lg 
                    shadow-gray-900/10 hover:shadow-gray-900/20  active:opacity-[0.85] active:shadow-none block w-full bg-blue-gray-900/10 text-blue-gray-900 shadow-none hover:scale-105 hover:shadow-none focus:scale-105 focus:shadow-none active:scale-100"
                    type="button"
                >
                    Thêm
                </button>
            </div> */}
        </div>
    );
};

export default MenuItem;
