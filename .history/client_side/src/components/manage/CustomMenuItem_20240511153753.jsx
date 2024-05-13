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
            className="relative flex justify-center items-center mx-auto p-[12px] gap-2 text-gray-700 bgr bg shadow-xl bg-clip-border rounded-xl 
            min-w-[180px]"
        >
            {/*//! Card-Info  */}
            <h5
                className={
                    "block text-lg antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900"
                }
            >
                {propsItem.name}
            </h5>

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
