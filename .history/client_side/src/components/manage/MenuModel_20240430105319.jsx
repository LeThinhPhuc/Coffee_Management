import { useEffect, useState } from "react";
import axios from "axios";
import "./styles.css";
import Loading from "./Loading";
import PropTypes from "prop-types";
import { useSelector } from "react-redux";
import { selectTypes } from "../../redux/Reducer/typeSlice";
import { useDispatch } from "react-redux";
import { addDrink, updateDrink } from "../../redux/Action/drinkAction";
import {
    addIngredient,
    updateIngredient,
} from "../../redux/Action/ingredientAction";
import { selectIngredients } from "../../redux/Reducer/ingredientSlice";

const MenuModel = (props) => {
    // Helper function to format the date
    const formatDate = (dateString) => {
        if (!dateString) return "";
        const date = new Date(dateString);
        const year = date.getFullYear();
        const month = date.getMonth() + 1; // January is 0!
        const day = date.getDate();

        return `${year}-${month.toString().padStart(2, "0")}-${day
            .toString()
            .padStart(2, "0")}`;
    };
    const now = formatDate(new Date().toISOString());

    const dispatch = useDispatch();
    // console.log("MENU MODELL");
    // console.log(props.item);

    //* lấy các field trong item truyền từ Manage, để riêng vậy để handle event "onChange" -> thay đổi input:text
    const [name, setName] = useState(props.item.name || "");
    const [info, setInfo] = useState(props.item.info || "");
    const [desc, setDesc] = useState(props.item.desc || "");
    const [image, setImage] = useState(props.item.image || null);
    const [entryDate, setEntryDate] = useState(now || "");
    const [expiryDate, setExpiryDate] = useState(
        formatDate(props.item.expiryDate) || ""
    );
    const [submitFail, setSubmitFail] = useState(false);

    //* form drink select drink type
    const [drinkTypeId, setDrinkTypeId] = useState(
        props.item.drinkTypeId || ""
    );
    const types = useSelector(selectTypes);
    if (drinkTypeId == "") setDrinkTypeId(types[0].id);

    //! from drink select ingredients
    const ingredients = useSelector(selectIngredients);
    const [ingreSelected, setIngreSelected] = useState();
    const [ingreAmount, setIngreAmount] = useState(1);
    const handleChangeIngreAmount = (event) => {
        const newValue = event.target.value;
        // Chỉ cho phép số và hạn chế độ dài tối đa là 4 ký tự
        if (/^\d*$/.test(newValue)) {
            setIngreAmount(newValue);
        }
    };
    const handleAddIngre = () => {
        console.log(ingreAmount);
    };
    console.log("ingredients");
    console.log(ingredients);
    console.log("Selected");
    console.log(ingreSelected);

    //* check để chỉnh sửa bên ingredient không đc sửa 3 field
    const isAdd = props.item.title.includes("Thêm đối tượng");

    //* Load image api
    const [isLoading, setIsLoading] = useState(false);

    //* Upload image dùng thư viên bên ngoài
    const handleUploadImage = async (event) => {
        setIsLoading(true);

        const preset_key = "umbkkwi4";
        // const cloud_name = "da0ikowpn";

        const file = event.target.files[0];

        const formData = new FormData();
        formData.append("file", file);
        formData.append("upload_preset", preset_key);

        try {
            const response = await axios.post(
                "https://api.cloudinary.com/v1_1/da0ikowpn/image/upload",
                formData
            );

            setImage(response.data.url);
            console.log(response);
        } catch (error) {
            console.error("Error uploading image:", error);
            throw error;
        }
        setIsLoading(false);
    };

    //* Khi bấm xác nhận -> lấy các field trong input thêm vào object, chưa có -> thêm, có -> update
    const handleSubmit = () => {
        if (props.item.type == "menu") {
            if (isAdd) {
                if (
                    name === "" ||
                    info === "" ||
                    image === null ||
                    //! Sửa chổ này nữa
                    // ingredients.length <= 0 ||
                    /[^0-9]/.test(info)
                ) {
                    setSubmitFail(true);
                    setTimeout(() => {
                        setSubmitFail(false);
                    }, 3000);
                    return;
                }

                //* add drink
                const drinkData = {
                    id: "string",
                    name: name,
                    price: parseFloat(info), //price
                    imagePath: image,
                    drinkTypeId: drinkTypeId, //drinkTypeId
                    //! Chổ này ingredient nè
                    ingredients: [],
                };
                console.log(drinkData);
                dispatch(addDrink(drinkData));
            }
            //* Edit
            else {
                //* update drink
                const drinkData = {
                    id: props.item.id,
                    name: name,
                    price: parseFloat(info), //price
                    imagePath: image,
                    drinkTypeId: drinkTypeId, //drinkTypeId
                    ingredients: [],
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
            {isLoading && <Loading></Loading>}

            <div
                className="justify-center items-center flex overflow-x-hidden overflow-y-hidden fixed inset-0 z-40 outline-none focus:outline-none 
                transition-all custom-animate-pulse"
            >
                <div className="relative w-auto overflow-hidden my-6 mx-auto max-w-3xl ">
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
                            <div>
                                <span className="block text-gray-700 text-sm font-bold mb-2">
                                    Hình ảnh
                                </span>
                                <div className="flex gap-2 items-center">
                                    <img
                                        id="preview-img"
                                        className="h-16 w-16 object-cover rounded-full"
                                        src={
                                            image ||
                                            `https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg`
                                        }
                                        alt="Current profile photo"
                                    />
                                    <input
                                        className="block w-full py-2 px-3 text-sm shadow text-gray-700 border  rounded-lg cursor-pointer 
                                        focus:outline-none focus:shadow-outline"
                                        id="file_input"
                                        type="file"
                                        accept="image/*" // Chỉ chấp nhận file hình ảnh
                                        onChange={handleUploadImage}
                                    ></input>
                                </div>
                            </div>

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

                            <div
                                className={
                                    !isAdd && props.type != "menu"
                                        ? `pointer-events-none`
                                        : ""
                                }
                            >
                                <label
                                    className="block text-gray-700 text-sm font-bold mb-2"
                                    htmlFor="price"
                                >
                                    {props.type == "menu"
                                        ? "Giá tiền"
                                        : "Số lượng"}
                                </label>
                                <input
                                    placeholder={
                                        props.type == "menu"
                                            ? "Giá tiền"
                                            : "Số lượng"
                                    }
                                    type="text"
                                    name="price"
                                    id="price"
                                    value={info}
                                    className="inline-block shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                        focus:outline-[#6f4436] focus:outline-none focus:shadow-outline"
                                    onChange={(e) => setInfo(e.target.value)}
                                />
                            </div>

                            {props.type == "menu" && ( //! Loại đồ uống
                                <div>
                                    <label
                                        className="block text-gray-700 text-sm font-bold mb-2"
                                        htmlFor="drinkTypeId"
                                    >
                                        Loại
                                    </label>

                                    <select
                                        id="drinkTypeId"
                                        name="drinkTypeId"
                                        value={drinkTypeId}
                                        onChange={(e) =>
                                            setDrinkTypeId(e.target.value)
                                        }
                                        className="p-2 bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                                    >
                                        {types.map((item) => (
                                            <option
                                                className="bg-white hover:bg-blue-100"
                                                key={item.id}
                                                value={item.id}
                                            >
                                                {item.name}
                                            </option>
                                        ))}
                                    </select>
                                </div>
                            )}

                            {props.type == "menu" && ( //! Nguyên liệu, [....]
                                <div>
                                    <label
                                        className="block text-gray-700 text-sm font-bold mb-2"
                                        htmlFor="ingredients"
                                    >
                                        Nguyên liệu
                                    </label>

                                    <div className="flex justify-between items-center">
                                        <select
                                            id="ingredients"
                                            name="ingredients"
                                            value={ingreSelected}
                                            onChange={(e) =>
                                                setIngreSelected(e.target.value)
                                            }
                                            className=" bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500  p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500
                                            inline-block w-[50%]
                                        "
                                        >
                                            {ingredients.map((item) => (
                                                <option
                                                    className="bg-white hover:bg-blue-100"
                                                    key={item.id}
                                                    value={item.id}
                                                >
                                                    {item.name}
                                                </option>
                                            ))}
                                        </select>

                                        <input
                                            type="text"
                                            name=""
                                            id=""
                                            value={ingreAmount}
                                            onChange={handleChangeIngreAmount}
                                            maxLength="4"
                                            className="shadow appearance-none border rounded  py-2 px-3 text-gray-700 leading-tight 
                                        focus:outline-[#6f4436] focus:outline-none focus:shadow-outline inline-block w-[60px] h-[40px]"
                                        />

                                        <button
                                            className=" hover:scale-105
                                    bg-emerald-500 text-white active:bg-emerald-600 font-bold uppercase text-sm px-6 py-3 rounded shadow hover:shadow-lg outline-none focus:outline-none mr-1 mb-1 ease-linear transition-all duration-150"
                                            type="button"
                                            onClick={() => {
                                                handleAddIngre();
                                            }}
                                        >
                                            Thêm
                                        </button>
                                    </div>
                                </div>
                            )}

                            {/* //* Hiện nhập entryDate và expiryDate của nguyên liệu */}
                            {props.type != "menu" && (
                                //* 2 ô cuối của ingredient, sẽ là 2 input điền ngày
                                <div
                                //* Cho phép edit Ingredient
                                // className={
                                //     /!isAdd ? `pointer-events-none` : ""
                                // }
                                >
                                    <div className="mb-6 pointer-events-none">
                                        <label
                                            className="block text-gray-700 text-sm font-bold mb-2 "
                                            htmlFor="entryDate"
                                        >
                                            Ngày nhập
                                        </label>
                                        <div className="relative">
                                            <div className="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                                                <svg
                                                    className="w-4 h-4 text-gray-500 dark:text-gray-400"
                                                    aria-hidden="true"
                                                    xmlns="http://www.w3.org/2000/svg"
                                                    fill="currentColor"
                                                    viewBox="0 0 20 20"
                                                >
                                                    <path
                                                        fillRule="evenodd"
                                                        d="M6 2a1 1 0 00-1 1v1H4a2 2 0 00-2 2v10a2 2 0 002 2h12a2 2 0 002-2V6a2 2 0 00-2-2h-1V3a1 1 0 10-2 0v1H7V3a1 1 0 00-1-1zM4 8h12v8H4V8zm1-2v1h10V6H5z"
                                                        clipRule="evenodd"
                                                    />
                                                </svg>
                                            </div>
                                            <input
                                                type="date"
                                                name="entryDate"
                                                id="entryDate"
                                                value={now}
                                                className="block w-full pl-10 p-2.5 text-sm text-gray-700 bg-gray-50 border border-gray-300 rounded-lg shadow-sm focus:outline-none focus:border-blue-500 focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                                                onChange={(e) =>
                                                    setEntryDate(e.target.value)
                                                }
                                                placeholder="Select date"
                                            />
                                        </div>
                                    </div>

                                    <div>
                                        <label
                                            className="block text-gray-700 text-sm font-bold mb-2"
                                            htmlFor="expiryDate"
                                        >
                                            Ngày hết hạn
                                        </label>
                                        <div className="relative">
                                            <div className="absolute inset-y-0 left-0 flex items-center pl-3 pointer-events-none">
                                                <svg
                                                    className="w-4 h-4 text-gray-500 dark:text-gray-400"
                                                    aria-hidden="true"
                                                    xmlns="http://www.w3.org/2000/svg"
                                                    fill="currentColor"
                                                    viewBox="0 0 20 20"
                                                >
                                                    <path
                                                        fillRule="evenodd"
                                                        d="M6 2a1 1 0 00-1 1v1H4a2 2 0 00-2 2v10a2 2 0 002 2h12a2 2 0 002-2V6a2 2 0 00-2-2h-1V3a1 1 0 10-2 0v1H7V3a1 1 0 00-1-1zM4 8h12v8H4V8zm1-2v1h10V6H5z"
                                                        clipRule="evenodd"
                                                    />
                                                </svg>
                                            </div>
                                            <input
                                                type="date"
                                                name="expiryDate"
                                                id="expiryDate"
                                                value={expiryDate}
                                                className="block w-full pl-10 p-2.5 text-sm text-gray-700 bg-gray-50 border border-gray-300 rounded-lg shadow-sm focus:outline-none focus:border-blue-500 focus:ring-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500"
                                                onChange={(e) =>
                                                    setExpiryDate(
                                                        e.target.value
                                                    )
                                                }
                                                placeholder="Select date"
                                            />
                                        </div>
                                    </div>
                                </div>
                            )}

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

MenuModel.propTypes = {
    item: PropTypes.object,
    type: PropTypes.string,
    handleCloseModel: PropTypes.func,
    setItem: PropTypes.func,
};

export default MenuModel;
