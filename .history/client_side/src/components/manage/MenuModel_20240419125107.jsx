import { useState } from "react";
import axios from "axios";
import "./styles.css";
import Loading from "./Loading";
import PropTypes from "prop-types";
import { useSelector } from "react-redux";
import { selectTypes } from "../../redux/Reducer/typeSlice";
import { useDispatch } from "react-redux";
import { addDrink } from "../../redux/Action/drinkAction";

const MenuModel = (props) => {
    const dispatch = useDispatch();
    // console.log(props.item);

    //! lấy các field trong item truyền từ Manage, để riêng vậy để handle event "onChange" -> thay đổi input:text
    const [name, setName] = useState(props.item.name || "");
    const [info, setInfo] = useState(props.item.info || "");
    const [desc, setDesc] = useState(props.item.desc || "");
    const [image, setImage] = useState(props.item.image || null);
    const [entryDate, setEntryDate] = useState(props.item.entryDate || "");
    const [expiryDate, setExpiryDate] = useState(props.item.expiryDate || "");
    const [category, setCategory] = useState(props.item.category || "");
    const [ingredients, setIngredients] = useState(
        props.item.ingredients || []
    );

    const types = useSelector(selectTypes);
    // console.log(types);

    //! check để chỉnh sửa bên ingredient không đc sửa 3 field
    const isAdd = props.item.title.includes("Thêm đối tượng");

    //! Load image api
    const [isLoading, setIsLoading] = useState(false);

    //! Upload image dùng thư viên bên ngoài
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

    //! Khi bấm xác nhận -> lấy các field trong input thêm vào object, chưa có -> thêm, có -> update
    const handleSubmit = () => {
        //! add drink
        const drinkData = {
            id: "string",
            name,
            price: info, //price
            imagePath: image,
            drinkTypeId: category, //drinkTypeId
        };
        console.log(drinkData);
        dispatch(addDrink(drinkData));

        //* api ingredients - chưa làm
        // const result = {
        //     ...props.item,
        //     name: name,
        //     image: image,
        //     info: info,
        //     desc: desc,

        //     //! nếu != "" thì sẽ trả về {field},
        //     //! field đó sẽ destructuring và thêm vào object result, không thì thôi
        //     ...(ingredients != "" && { ingredients }),
        //     ...(category != "" && { category }),

        //     ...(entryDate != "" && { entryDate }),
        //     ...(expiryDate != "" && { expiryDate }),
        // };
        // console.log(result);
    };

    return (
        <div>
            {isLoading && <Loading></Loading>}
            <div className="justify-center items-center flex overflow-x-hidden overflow-y-auto fixed inset-0 z-40 outline-none focus:outline-none transition-all custom-animate-pulse">
                <div className="relative w-auto my-6 mx-auto max-w-3xl">
                    {/*//! content*/}
                    <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none">
                        {/*header*/}
                        <div className="flex items-start justify-between p-5 border-b border-solid border-blueGray-200 rounded-t">
                            <h3 className="text-3xl text-gray-700 font-bold">
                                {props.item.title}
                            </h3>
                        </div>

                        {/*//! body*/}
                        <form className="relative p-6 flex flex-col gap-6">
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

                            {/* {props.type == "menu" && (
                                //! Ô cuối của Menu, sẽ là "Mô tả"
                                <div>
                                    <label
                                        className="block text-gray-700 text-sm font-bold mb-2"
                                        htmlFor="desc"
                                    >
                                        Mô tả
                                    </label>
                                    <input
                                        placeholder="Mô tả"
                                        type="text"
                                        name="desc"
                                        id="desc"
                                        value={desc}
                                        className="inline-block shadow-md appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                    focus:outline-[#6f4436] focus:outline-none focus:shadow-outline "
                                        onChange={(e) =>
                                            setDesc(e.target.value)
                                        }
                                    />
                                </div>
                            )} */}

                            {props.type == "menu" && ( //! Loại đồ uống
                                //! Ô cuối của Menu, sẽ là "Mô tả"
                                <div>
                                    <label
                                        className="block text-gray-700 text-sm font-bold mb-2"
                                        htmlFor="category"
                                    >
                                        Loại
                                    </label>

                                    <select
                                        id="category"
                                        name="category"
                                        onChange={(e) =>
                                            setCategory(e.target.value)
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
                                //! Ô cuối của Menu, sẽ là "Mô tả"
                                <div>
                                    <label
                                        className="block text-gray-700 text-sm font-bold mb-2"
                                        htmlFor="ingredients"
                                    >
                                        Nguyên liệu - chưa hoàn thành
                                        {/* https://flowbite.com/docs/forms/select/ */}
                                    </label>
                                    <input
                                        placeholder="Nguyên liệu"
                                        type="text"
                                        name="ingredients"
                                        id="ingredients"
                                        value={ingredients}
                                        className="inline-block shadow-md appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                    focus:outline-[#6f4436] focus:outline-none focus:shadow-outline "
                                        onChange={(e) =>
                                            setIngredients(e.target.value)
                                        }
                                    />
                                </div>
                            )}

                            {/* //! Hiện nhập entryDate và expiryDate của nguyên liệu */}
                            {props.type != "menu" && (
                                //! 2 ô cuối của ingredient, sẽ là 2 input điền ngày
                                <div
                                    className={
                                        !isAdd ? `pointer-events-none` : ""
                                    }
                                >
                                    <div className="mb-6">
                                        <label
                                            className="block text-gray-700 text-sm font-bold mb-2"
                                            htmlFor="entryDate"
                                        >
                                            Ngày nhập
                                        </label>
                                        <input
                                            placeholder="Ngày nhập"
                                            type="text"
                                            name="entryDate"
                                            id="entryDate"
                                            value={entryDate}
                                            className="inline-block shadow-md appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                    focus:outline-[#6f4436] focus:outline-none focus:shadow-outline "
                                            onChange={(e) =>
                                                setEntryDate(e.target.value)
                                            }
                                        />
                                    </div>

                                    <div
                                        className={
                                            !isAdd ? `pointer-events-none` : ""
                                        }
                                    >
                                        <label
                                            className="block text-gray-700 text-sm font-bold mb-2"
                                            htmlFor="expiryDate"
                                        >
                                            Ngày hết hạn
                                        </label>
                                        <input
                                            placeholder="Ngày hết hạn"
                                            type="text"
                                            name="expiryDate"
                                            id="expiryDate"
                                            value={expiryDate}
                                            className="inline-block shadow-md appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                    focus:outline-[#6f4436] focus:outline-none focus:shadow-outline "
                                            onChange={(e) =>
                                                setExpiryDate(e.target.value)
                                            }
                                        />
                                    </div>
                                </div>
                            )}

                            {/*//! button*/}
                            <div className="flex items-center justify-end p-6 border-t border-solid border-blueGray-200 rounded-b">
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
                                        props.handleCloseModel();
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
