import { useState } from "react";
import MenuItem from "./MenuItem";
import MenuModel from "./MenuModel";
import PropTypes from "prop-types";
import "./styles.css";
import { deleteDrink, updateDrink } from "../../redux/Action/drinkAction";
import { useDispatch } from "react-redux";
import {
    deleteIngredient,
    updateIngredient,
} from "../../redux/Action/ingredientAction";

const Manage = (props) => {
    const dispatch = useDispatch();

    //* state để quản lí toggle  button "Chỉnh sửa", ẩn/hiện modal
    const [showModal, setShowModal] = useState(false);
    const [isEditing, setIsEditing] = useState(false);

    //* State với các field để hiển thị trong modal, type để check là Menu hay Ingredient
    const [item, setItem] = useState({
        title: null,
        image: null,
        name: null,
        info: null,
        desc: null,
        type: props.type,
    });

    //* button "Chỉnh sửa"
    const handleClickEdit = () => {
        setIsEditing((isEditing) => !isEditing);
    };

    //* ẩn/hiện modal
    const handleShowModel = () => {
        setShowModal(true);
    };

    //* ẩn/hiện modal
    const handleCloseModel = () => {
        setShowModal(false);
    };

    //* icon trash trong MenuItem
    const handleDeleteItem = (id) => {
        // console.log(`Deleted item at [${index}] of [${category}]`);
        console.log(id);
        props.type == "menu"
            ? dispatch(deleteDrink(id))
            : dispatch(deleteIngredient(id));
    };

    //! Icon (+) trong MenuItem, chỉ có trong Ingredient
    const handleAddIngredient = (index, item, category) => {
        const amount = item.amount + 10;
        const ingredientData = {
            ...item,
            amount: amount,
        };

        dispatch(updateIngredient(item.id, ingredientData));
    };

    return (
        <div className="container mx-auto mt-20 p-[75px] pt-0  rounded-xl shadow-lg bg-clip-border">
            {/*//! Button */}
            <div className="flex ml-[7px] gap-5 mt-4 mb-8">
                <div className="">
                    <button
                        // focus:opacity-[0.85]
                        // focus:scale-105 focus:shadow-none
                        className="text-base align-middle select-none font-sans font-bold text-center bg-[#10b981] text-white  transition-all
                    disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none  py-3 px-6 rounded-lg
                    shadow-gray-900/10 hover:shadow-gray-900/20  active:opacity-[0.85] active:shadow-none block w-full bg-blue-gray-900/10 text-blue-gray-900 shadow-none hover:scale-105 hover:shadow-none  active:scale-100"
                        type="button"
                        onClick={() => {
                            setItem(() => ({
                                image: null,
                                name: null,
                                info: null,
                                desc: null,
                                type: props.type,
                                title: "Thêm đối tượng", //! set title cho model
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

            {/*//! Item */}
            {props.data &&
                props.data.map((data, index) => {
                    return (
                        <div key={index} className="mb-[50px]">
                            <h3 className="ml-[7px] mb-4  block text-3xl antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                                {data.category}
                            </h3>

                            <div className=" gap-x-6 gap-y-10 grid grid-cols-6 rounded-xl">
                                {data.items?.map((item, index) => {
                                    return (
                                        <MenuItem
                                            key={index}
                                            id={index}
                                            category={data.category}
                                            isEditing={isEditing}
                                            setItem={setItem}
                                            item={item}
                                            handleShowModel={handleShowModel}
                                            handleDeleteItem={handleDeleteItem}
                                            handleAddIngredient={
                                                handleAddIngredient
                                            }
                                            type={props.type}
                                        ></MenuItem>
                                    );
                                })}
                            </div>
                        </div>
                    );
                })}

            {/*//! Model */}
            {showModal && (
                <MenuModel
                    handleCloseModel={handleCloseModel}
                    item={item}
                    setItem={setItem}
                    type={props.type}
                ></MenuModel>
            )}
        </div>
    );
};

Manage.propTypes = {
    data: PropTypes.array,
    type: PropTypes.string,
};

export default Manage;
