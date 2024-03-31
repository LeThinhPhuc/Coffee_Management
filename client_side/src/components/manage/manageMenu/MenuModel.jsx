import React, { useState } from "react";
import "./styles.css";

const MenuModel = (props) => {
    const [name, setName] = useState(props.item.name || "");
    const [price, setPrice] = useState(props.item.price || "");
    const [desc, setDesc] = useState(props.item.desc || "");
    const [image, setImage] = useState(props.item.image || "");

    const handleImageChange = (event) => {
        const file = event.target.files[0];
        const imageUrl = URL.createObjectURL(file);
        console.log(imageUrl);

        //! Set image
        setImage(imageUrl);

        var output = document.getElementById("preview-img");

        output.src = URL.createObjectURL(file);
        output.onload = function () {
            URL.revokeObjectURL(output.src); // free memory
        };
    };

    const handleSubmit = () => {
        const result = {
            ...props.item,
            name: name,
            price: price,
            desc: desc,
            image: image,
            // title: "Sửa sản phẩm",
        };

        console.log(result);
    };

    return (
        <div>
            <div className="justify-center items-center flex overflow-x-hidden overflow-y-auto fixed inset-0 z-50 outline-none focus:outline-none transition-all custom-animate-pulse">
                <div className="relative w-auto my-6 mx-auto max-w-3xl">
                    {/*content*/}
                    <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none">
                        {/*header*/}
                        <div className="flex items-start justify-between p-5 border-b border-solid border-blueGray-200 rounded-t">
                            <h3 className="text-3xl text-gray-700 font-bold">
                                {props.item.title}
                            </h3>

                            {/* <button
                                className="p-1 ml-auto bg-transparent border-0 text-black opacity-5 float-right text-3xl leading-none font-semibold outline-none focus:outline-none"
                                onClick={props.handleCloseModel}
                            >
                                <span className="bg-transparent text-black opacity-5 h-6 w-6 text-2xl block outline-none focus:outline-none">
                                    X
                                </span>
                            </button> */}
                        </div>

                        {/*body*/}
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
                                        onChange={handleImageChange}
                                    ></input>
                                </div>
                            </div>

                            <div>
                                <label
                                    className="block text-gray-700 text-sm font-bold mb-2"
                                    htmlFor="username"
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
                                    onChange={(e) => setName(e.target.value)}
                                />
                            </div>

                            <div>
                                <label
                                    className="block text-gray-700 text-sm font-bold mb-2"
                                    htmlFor="price"
                                >
                                    Giá tiền
                                </label>
                                <input
                                    placeholder="Giá tiền (VNĐ)"
                                    type="text"
                                    name="price"
                                    id="price"
                                    value={price}
                                    className="inline-block shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight 
                                    focus:outline-[#6f4436] focus:outline-none focus:shadow-outline"
                                    onChange={(e) => setPrice(e.target.value)}
                                />
                            </div>

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
                                    focus:outline-[#6f4436] focus:outline-none focus:shadow-outline"
                                    onChange={(e) => setDesc(e.target.value)}
                                />
                            </div>

                            {/*button*/}
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
            <div className="opacity-25 fixed inset-0 z-40 bg-black"></div>
        </div>
    );
};

export default MenuModel;
