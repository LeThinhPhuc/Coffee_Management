import { useEffect, useState } from "react";
import axios from "axios";
import "../styles.css";
import Loading from "../Loading";
import PropTypes from "prop-types";
import { useSelector } from "react-redux";

import { useDispatch } from "react-redux";
import { selectIngredients } from "../../../redux/Reducer/ingredientSlice";
import { selectTypes } from "../../../redux/Reducer/typeSlice";

import { addDrink, updateDrink } from "../../../redux/Action/drinkAction";
import MenuModelDetail from "../MenuModelDetail";
import {
    addIngredient,
    updateIngredient,
} from "../../../redux/Action/ingredientAction";

const CustomMenuModel = (props) => {
    const dispatch = useDispatch();
    console.log("MENU MODELL");
    console.log(props.item);
    // console.log(props.type);

    //* lấy các field trong item truyền từ Manage, để riêng vậy để handle event "onChange" -> thay đổi input:text
    const [name, setName] = useState(props.item.name || "");
    const [submitFail, setSubmitFail] = useState(false);

    //* check để chỉnh sửa bên ingredient không đc sửa 3 field
    const isAdd = props.item.title.includes("Thêm đối tượng");

    //* Khi bấm xác nhận -> lấy các field trong input thêm vào object, chưa có -> thêm, có -> update
    const handleSubmit = () => {
        if (props.type == "menu") {
            // console.log("handleSubmit");
            if (
                name === "" ||
                info === "" ||
                image === null ||
                ingreArray.length <= 0 ||
                /[^0-9]/.test(info)
            ) {
                setSubmitFail(true);
                setTimeout(() => {
                    setSubmitFail(false);
                }, 3000);
                return;
            }
            if (isAdd) {
                //* add drink
                const ingredients = ingreArray.map((ing) => ({
                    ingredientId: ing.item.id,
                    quantity: parseInt(ing.quantity, 10),
                }));

                const drinkData = {
                    id: "string",
                    name: name,
                    price: parseFloat(info), //price
                    imagePath: image,
                    drinkTypeId: drinkTypeId, //drinkTypeId
                    //! Chổ này ingredient nè
                    ingredients: ingredients,
                };
                console.log(drinkData);
                dispatch(addDrink(drinkData));
            }
            //* Edit
            else {
                const ingredients = ingreArray.map((ing) => ({
                    ingredientId: ing.item.id,
                    quantity: parseInt(ing.quantity, 10),
                }));
                //* update drink
                const drinkData = {
                    id: props.item.id,
                    name: name,
                    price: parseFloat(info), //price
                    imagePath: image,
                    drinkTypeId: drinkTypeId, //drinkTypeId
                    ingredients: ingredients,
                };
                console.log("Data to update");
                console.log(drinkData);
                dispatch(updateDrink(drinkData));
            }
        }
        //* Ingredient
        else {
            //* để check ngày nhập <= ngày hết hạn
            const entryDateObj = new Date(entryDate);
            const expiryDateObj = new Date(expiryDate);
            if (
                image === null ||
                name === "" ||
                info === "" ||
                /[^0-9]/.test(info) ||
                expiryDate == "" ||
                entryDate == "" ||
                entryDateObj >= expiryDateObj
            ) {
                // Nếu có trường thông tin nào còn trống, đặt submitFail thành true
                setSubmitFail(true);
                setTimeout(() => {
                    setSubmitFail(false);
                }, 3000);
                // Dừng hàm handleSubmit ở đây
                return;
            }

            const ingredientData = {
                id: props.item.id,
                name: name,
                imagePath: image,
                amount: info,
                expiryDate: expiryDate,
            };

            isAdd
                ? dispatch(addIngredient(ingredientData))
                : dispatch(updateIngredient(props.item.id, ingredientData));
        }

        props.handleCloseModel();
    };

    return (
        <div>
            <div
                className="justify-center items-center flex  overflow-y-hidden fixed inset-0 z-40 outline-none focus:outline-none 
                transition-all custom-animate-pulse"
            >
                <div className="relative w-auto  my-6 mx-auto max-w-3xl ">
                    {/*//! Alert */}
                    <div
                        className={`alert ${
                            submitFail ? "active" : ""
                        } z-50 fixed right-10 top-10 flex items-center p-4 mb-4 text-sm
                                text-yellow-800 border border-yellow-300 rounded-lg bg-yellow-50 dark:bg-gray-800
                                dark:text-yellow-300 dark:border-yellow-800`}
                        role="alert"
                    >
                        <svg
                            className="flex-shrink-0 inline w-4 h-4 me-3"
                            aria-hidden="true"
                            xmlns="http://www.w3.org/2000/svg"
                            fill="currentColor"
                            viewBox="0 0 20 20"
                        >
                            <path d="M10 .5a9.5 9.5 0 1 0 9.5 9.5A9.51 9.51 0 0 0 10 .5ZM9.5 4a1.5 1.5 0 1 1 0 3 1.5 1.5 0 0 1 0-3ZM12 15H8a1 1 0 0 1 0-2h1v-3H8a1 1 0 0 1 0-2h2a1 1 0 0 1 1 1v4h1a1 1 0 0 1 0 2Z" />
                        </svg>
                        <span className="sr-only">Info</span>
                        <div>
                            <span className="font-medium">Thông báo!</span> Càn
                            điền đầy đủ thông tin, chính xác thông tin.
                        </div>
                    </div>

                    {/*//! content*/}
                    <div className="border-0 rounded-lg shadow-lg relative my-2 flex flex-col w-full bg-white outline-none focus:outline-none ">
                        {/*header*/}
                        <div className="flex items-start justify-between p-5 border-b border-solid border-blueGray-200 rounded-t">
                            <h3 className="text-3xl text-gray-700 font-bold">
                                {props.item.title}
                            </h3>
                        </div>

                        {/*//! body*/}
                        <form className="relative p-6 flex flex-col gap-5">
                            {/* //* Tên */}
                            <div>
                                <label
                                    className="block text-gray-700 text-sm font-bold mb-2"
                                    htmlFor="name"
                                >
                                    Tên
                                </label>
                                <input
                                    placeholder="Tên sản phẩm"
                                    type="text"
                                    name="name"
                                    id="name"
                                    value={name}
                                    className="inline-block shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                        focus:outline-[#6f4436] focus:outline-none focus:shadow-outline"
                                    //! Mỗi lần thay đổi input:text, re-render để cập nhật
                                    onChange={(e) => setName(e.target.value)}
                                />
                            </div>

                            {/*//! button*/}
                            <div className="flex items-center justify-end p-4 border-t border-solid border-blueGray-200 rounded-b">
                                <button
                                    className="hover:scale-105 text-red-500 background-transparent font-bold uppercase px-6 py-2 text-sm outline-none focus:outline-none mr-1 mb-1 ease-linear transition-all duration-150"
                                    type="button"
                                    onClick={props.handleCloseModel}
                                >
                                    Đóng
                                </button>
                                <button
                                    className=" hover:scale-105
                                    bg-emerald-500 text-white active:bg-emerald-600 font-bold uppercase text-sm px-6 py-3 rounded shadow hover:shadow-lg outline-none focus:outline-none mr-1 mb-1 ease-linear transition-all duration-150"
                                    type="button"
                                    onClick={() => {
                                        handleSubmit();
                                    }}
                                >
                                    Xác nhận
                                </button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <div className="opacity-25 fixed inset-0 z-30 bg-black"></div>
        </div>
    );
};

CustomMenuModel.propTypes = {
    item: PropTypes.object,
    type: PropTypes.string,
    handleCloseModel: PropTypes.func,
    setItem: PropTypes.func,
};

export default CustomMenuModel;
