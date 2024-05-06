import { useEffect, useState } from "react";
import "./styles.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import PropTypes from "prop-types";
import {
    faPen,
    faTrash,
    faCirclePlus,
    faChampagneGlasses,
} from "@fortawesome/free-solid-svg-icons";

//* Card
const MenuItem = (props) => {
    //* định dạng lại date time
    function formatDate(dateString) {
        const date = new Date(dateString);
        return date.toLocaleDateString("vi-VN", {
            day: "2-digit",
            month: "2-digit",
            year: "numeric",
        });
    }

    //* Lấy Item được truyền vào, để có thể sửa.
    const [propsItem, setPropsItem] = useState(props.item);
    console.log(propsItem);

    //* Định nghĩa field "desc" tùy theo component
    const desc =
        propsItem.ingredients && propsItem.ingredients.length > 0
            ? propsItem.ingredients
                  .map((item) => `${item.quantity} ${item.ingredientName}`)
                  .join(", ")
            : `${formatDate(propsItem.dateCreated)} - ${formatDate(
                  propsItem.expiryDate
              )}`;

    useEffect(() => {
        setPropsItem({
            //* ... là destructuring object, bung hết các field của object
            ...props.item,

            //* field chưa có -> thêm, có -> update
            desc: desc,
            info: propsItem.quantity,
        });
    }, []);

    return (
        <div
            className="relative flex flex-col justify-start mx-auto p-[12px] gap-2 text-gray-700 bgr bg shadow-xl bg-clip-border rounded-xl 
            w-[180px] h-[300px]"
        >
            {/*//! Card-Image */}
            <div className="relative w-full h-[150px] min-h-[150px] max-h-[150px]  flex-1  overflow-hidden text-white shadow-lg bg-clip-border rounded-xl bg-blue-gray-500 shadow-blue-gray-500/40">
                <img
                    src={propsItem.image}
                    alt="card-image"
                    className="w-full h-full object-cover"
                />
            </div>

            {/*//! Card-Info */}
            <div className="">
                <h5
                    className={`${
                        propsItem.price && "min-h-[35px]"
                    } block text-lg antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900
                     `}
                >
                    {propsItem.name}
                </h5>
                <p className="font-bold text-[#854442] my-2">
                    {props.type == "menu" ? "Giá: " : "Số lượng: "}
                    {propsItem.price || propsItem.amount}
                    {props.type == "menu" ? " VNĐ" : ""}
                </p>
                <p className="block text-base antialiased font-semibold leading-relaxed text-inherit">
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
                        props.setItem(() => ({
                            ...propsItem,
                            title: "Sửa đối tượng",
                            image: propsItem.image,
                            name: propsItem.name,
                            info: propsItem.info || propsItem.price,
                            desc: propsItem.desc,
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

MenuItem.propTypes = {
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

export default MenuItem;
