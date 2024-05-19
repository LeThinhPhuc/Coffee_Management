import { useState } from "react";
import MenuItem from "./MenuItem";
import MenuModel from "./MenuModel";
import PropTypes from "prop-types";
import "./styles.css";
import { deleteDrink } from "../../redux/Action/drinkAction";
import { useDispatch, useSelector } from "react-redux";
import {
    addIngredient,
    deleteIngredient,
    updateIngredient,
} from "../../redux/Action/ingredientAction";
import CustomMenuItem from "./manageDrinkType/CustomMenuItem";
import CustomMenuModel from "./manageDrinkType/CustomMenuModel";
import { addDrinkType, deleteDrinkType } from "../../redux/Action/typeAction";
import { selectIngredientsError } from "../../redux/Reducer/ingredientSlice";

const Manage = (props) => {
    // console.log("DATA");
    // console.log(props.data);
    // console.log(props.type);
    const dispatch = useDispatch();

    //* state để quản lí toggle  button "Chỉnh sửa", ẩn/hiện modal
    const [showModal, setShowModal] = useState(false);
    const [isEditing, setIsEditing] = useState(false);

    //* State với các field để hiển thị trong modal, type để check là Menu hay Ingredient
    const [item, setItem] = useState({
        title: "",
        image: "",
        name: "",
        info: "",
        desc: "",
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
    const [errorMessage, setErrorMessage] = useState(null);
    const error = useSelector(selectIngredientsError);

    if (props.type == "ingredient") {
    }

    const handleDeleteItem = (id) => {
        // console.log(props.type);
        // console.log(id);
        switch (props.type) {
            case "menu":
                // console.log("menu");
                dispatch(deleteDrink(id));
                break;
            case "drinkType":
                // console.log("drink type");
                dispatch(deleteDrinkType(id));
                break;
            default:
                // console.log("ingredient");
                dispatch(deleteIngredient(id));
                break;
        }
    };

    //! Icon (+) trong MenuItem, chỉ có trong Ingredient
    const handleAddIngredient = (item) => {
        const amount = item.amount + 10;
        const ingredientData = {
            ...item,
            amount: amount,
        };

        dispatch(updateIngredient(item.id, ingredientData));
    };

    // sao thiếu handle Addd Drink Drink>>>
    const handleAddDrinkType = (item) => {
        // const amount = item.amount + 10;
        const drinkData = {
            ...item,
        };

        dispatch(addDrinkType(drinkData));
    };

    const handleAddItem = (item) => {
        // console.log(`Deleted item at [${index}] of [${category}]`);
        console.log(item);
        switch (props.type) {
            case "menu":
                dispatch(addDrink(item));
                break;
            case "drinkType":
                dispatch(addDrinkType(item));
                break;
            default:
                dispatch(addIngredient(item));
                break;
        }
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
                                image: "",
                                name: "",
                                info: "",
                                desc: "",
                                type: props.type,
                                ingredients: [],
                                title: "Add item", //! set title cho model
                            }));
                            setShowModal(true);
                        }}
                    >
                        Add
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
                        Edit
                    </button>
                </div>
            </div>

            {/*//! Item */}

            {props.data &&
                props.data.map((propsData, index) => {
                    return (
                        <div key={index} className="mb-[50px]">
                            <h3 className="ml-[7px] mb-4  block text-3xl antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                                {propsData.category}
                            </h3>

                            <div className=" gap-x-6 gap-y-10 grid grid-cols-6 rounded-xl">
                                {propsData.items?.map((item, index) => {
                                    if (props.type != "drinkType") {
                                        return (
                                            <MenuItem
                                                key={index}
                                                id={index}
                                                category={propsData.category}
                                                isEditing={isEditing}
                                                setItem={setItem}
                                                item={item}
                                                handleShowModel={
                                                    handleShowModel
                                                }
                                                handleDeleteItem={
                                                    handleDeleteItem
                                                }
                                                handleAddIngredient={
                                                    handleAddIngredient
                                                }
                                                type={props.type}
                                            ></MenuItem>
                                        );
                                    } else {
                                        return (
                                            <CustomMenuItem
                                                key={index}
                                                id={index}
                                                category={propsData.category}
                                                isEditing={isEditing}
                                                setItem={setItem}
                                                item={item}
                                                handleShowModel={
                                                    handleShowModel
                                                }
                                                handleDeleteItem={
                                                    handleDeleteItem
                                                }
                                                handleAddIngredient={
                                                    handleAddIngredient
                                                }
                                                type={props.type}
                                            ></CustomMenuItem>
                                        );
                                    }
                                })}
                            </div>
                        </div>
                    );
                })}

            {/*
            {Array.isArray(props.data) && props.data.length > 0 ? (
                props.data.map((propsData, index) => (
                    <div key={index} className="mb-[50px]">
                        <h3 className="ml-[7px] mb-4 block text-3xl antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                            {propsData.category}
                        </h3>

                        <div className="gap-x-6 gap-y-10 grid grid-cols-6 rounded-xl">
                            {propsData.items?.map((item, index) => {
                                if (props.type != "drinkType") {
                                    return (
                                        <MenuItem
                                            key={index}
                                            id={index}
                                            category={propsData.category}
                                            isEditing={isEditing}
                                            setItem={setItem}
                                            item={item}
                                            handleShowModel={
                                                handleShowModel
                                            }
                                            handleDeleteItem={
                                                handleDeleteItem
                                            }
                                            handleAddIngredient={
                                                handleAddIngredient
                                            }
                                            type={props.type}
                                        ></MenuItem>
                                    );
                                } else {
                                    return (
                                        <CustomMenuItem
                                            key={index}
                                            id={index}
                                            category={propsData.category}
                                            isEditing={isEditing}
                                            setItem={setItem}
                                            item={item}
                                            handleShowModel={
                                                handleShowModel
                                            }
                                            handleDeleteItem={
                                                handleDeleteItem
                                            }
                                            handleAddIngredient={
                                                handleAddIngredient
                                            }
                                            handleAddItem= {handleAddItem}
                                            type={props.type}
                                        ></CustomMenuItem>
                                    );
                                }
                            })}
                        </div>
                    </div>
                ))
            ) : (
                <p className="ml-[7px] text-3xl antialiased font-extrabold leading-snug tracking-normal text-blue-gray-900">
                    No items available.
                </p>
            )}
            */}

            {/*//! Model */}
            {showModal &&
                (props.type !== "drinkType" ? (
                    <MenuModel
                        handleCloseModel={handleCloseModel}
                        item={item}
                        setItem={setItem}
                        type={props.type}
                    />
                ) : (
                    <CustomMenuModel
                        handleCloseModel={handleCloseModel}
                        item={item}
                        setItem={setItem}
                        type={props.type}
                        shopId={props.shopId}
                    />
                ))}
        </div>
    );
};

Manage.propTypes = {
    data: PropTypes.array,
    type: PropTypes.string,
    shopId: PropTypes.string,
};

export default Manage;
