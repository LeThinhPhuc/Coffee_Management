import { useEffect, useState } from "react";
import "./styles.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import PropTypes from "prop-types";
import {
    faPen,
    faTrash,
    faCirclePlus,
} from "@fortawesome/free-solid-svg-icons";

//* Card
const CustomMenuItem = (props) => {
    // console.log("MenuItem");
    //* định dạng lại date time
    function formatDate(dateString) {
        const date = new Date(dateString);
        return date.toLocaleDateString("vi-VN", {
            day: "2-digit",
            month: "2-digit",
            year: "numeric",
        });
    }
    console.log(props.item);

    //* Lấy Item được truyền vào, để có thể sửa.
    const [propsItem, setPropsItem] = useState([]);
    // console.log(propsItem);

    useEffect(() => {
        setPropsItem(props.item);
    }, [props.item]);

    return (
        <div
            className="relative flex flex-col justify-start mx-auto p-[12px] gap-2 text-gray-700 bgr bg shadow-xl bg-clip-border rounded-xl 
            w-[180px]"
        >
            {/*//! Card-Image */}
            {/* <div className="relative w-full h-[150px] min-h-[150px] max-h-[150px]  flex-1  overflow-hidden text-white shadow-lg bg-clip-border rounded-xl bg-blue-gray-500 shadow-blue-gray-500/40">
                <img
                    src={propsItem.image || propsItem.imagePath}
                    alt="card-image"
                    className="w-full h-full object-cover"
                />
            </div> */}

            {/*//! Card-Info  */}
            <div className="">
                <h5
                    className={`${
                        propsItem.price && "min-h-[35px]"
                    } block text-lg antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900
                     `}
                >
                    {propsItem.name}
                </h5>

                {/* <p className="font-bold text-[#854442] my-2">
                    {props.type == "menu" ? "Giá: " : "Số lượng: "}
                    {propsItem.price || propsItem.amount}
                    {props.type == "menu" ? " VNĐ" : ""}
                </p>
                {props.type == "menu" ? (
                    <p className="block text-base antialiased font-semibold leading-relaxed text-inherit">
                        Nguyên liệu: {ingredients || "..."}
                    </p>
                ) : (
                    <p className="block text-base antialiased font-semibold leading-relaxed text-inherit">
                        <span className="block">
                            NSX: {formatDate(propsItem.dateCreated)}
                        </span>
                        <span className="block">
                            HSD: {formatDate(propsItem.expiryDate)}
                        </span>
                    </p>
                )} */}
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
                            props.handleAddIngredient(propsItem);
                        }}
                    >
                        <FontAwesomeIcon icon={faCirclePlus} />
                    </p>
                )}

                {/*//!Edit */}
                <p
                    className="cursor-pointer size-[20px] text-[#ffa400] rounded-full hover:scale-125 transition-all"
                    onClick={() => {
                        props.setItem(() => ({
                            ...propsItem,
                            title: "Sửa đối tượng",
                            image: propsItem.image || propsItem.imagePath,
                            name: propsItem.name,
                            info: propsItem.info || propsItem.price,
                            desc: propsItem.desc,
                            ingredients: propsItem.ingredients,
                            drinkTypeId: propsItem.drinkTypeId,
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
                        props.handleDeleteItem(propsItem.id);
                    }}
                >
                    <FontAwesomeIcon icon={faTrash} />
                </p>
            </div>
        </div>
    );
};

CustomMenuItem.propTypes = {
    id: PropTypes.number,
    category: PropTypes.string,
    isEditing: PropTypes.bool,
    setItem: PropTypes.func,
    item: PropTypes.object,
    handleShowModel: PropTypes.func,
    handleDeleteItem: PropTypes.func,
    handleAddIngredient: PropTypes.func,
    type: PropTypes.string,
};

export default CustomMenuItem;
