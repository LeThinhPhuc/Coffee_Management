// Coffee_Management/client_side/src/components/Discount/Modal/Modal.jsx
import PropTypes from "prop-types";
import Input from "./Input";
import { useFormik } from "formik";
import * as Yup from "yup";
import { useEffect } from "react";

// ***    ERROR if no item "user" in Local Storage    **
// Get the shop ID from the first shop in the array of shops
// const { shops } = JSON.parse(localStorage.getItem("user"));
// const shopId = shops[0].id;

// FIX case null/undefined of not logged in (no "user" item in Local Storage)
let shopId = null;

  try {
    const user = JSON.parse(localStorage.getItem("user"));
    if (user && user.shops && user.shops.length > 0) {
      shopId = user.shops[0].id;
    } else {
      console.warn('No shops available for the user');
    }
  } catch (error) {
    console.warn('User data is not available in localStorage or malformed', error);
  }

const Modal = ({
  item,
  visible,
  onClose,
  handleAdd,
  handleUpdate,
  setCurrentDiscount,
}) => {

  if (!setCurrentDiscount) {
    console.warn('setCurrentDiscount is undefined');
    return null; // or you can return a placeholder element or message
  }
  
  const formik = useFormik({
    initialValues: {
      name: "",
      startDate: "",
      endDate: "",
      discountPercent: "",
      shopId: shopId,
    },
    validationSchema: Yup.object({
      name: Yup.string().required("Required"),
      startDate: Yup.date().required("Required"),
      endDate: Yup.date().required("Required"),
      discountPercent: Yup.number("Please enter number")
        .required("Required")
        .min(1, "Percent must be greater than or equal to 1")
        .max(100, "Percent must be less than or equal to 100"),
    }),
    onSubmit: (values) => {
      if (item) {
        handleUpdate({ ...values, id: item.id });
        setCurrentDiscount(null);
      } else {
        handleAdd(values);
      }
    },
  });

  useEffect(() => {
    if (item) {
      formik.setValues({
        name: item.name,
        startDate: item.startDate,
        endDate: item.endDate,
        discountPercent: item.discountPercent,
        shopId: shopId,
      });
    }
  }, [item, shopId]);

  if (!visible) return null;
  return (
    <div className="fixed bg-black inset-0 bg-opacity-30 backdrop-blur-sm flex justify-center items-center">
      <div className="bg-white w-10/12 md:w-5/12 lg:w-4/12 h-4/6 z-auto rounded-2xl mt-10 p-2.5 drop-shadow-2xl">
        <div className="flex justify-between align-middle px-5 my-3">
          <h3 className="font-medium font-montserrat">
            {item ? "Edit Discount" : "New Discount Coupon"}
          </h3>
          <button
            onClick={onClose}
            className="rounded-full px-[10px] text-sm text-white py-1 bg-slate-200 hover:bg-red-400"
          >
            X
          </button>
        </div>
        <form onSubmit={formik.handleSubmit}>
          <div className="mt-6 px-7 text-sm">
            <div className="flex flex-col mb-4">
              <Input
                id="name"
                label="Discount Code"
                type="text"
                placeholder="CODEABC..."
                value={formik.values.name}
                onChange={formik.handleChange}
              />
              {formik.errors.name && formik.touched.name ? (
                <p className="mt-2 text-xs text-red-500">{formik.errors.name}</p>
              ) : null}
            </div>
            <div className="flex flex-col mb-4">
              <Input
                id="startDate"
                label="Start Date"
                type="date"
                value={formik.values.startDate}
                onChange={formik.handleChange}
              />
              {formik.errors.startDate && formik.touched.startDate ? (
                <p className="mt-2 text-xs text-red-500">
                  {formik.errors.startDate}
                </p>
              ) : null}
            </div>
            <div className="flex flex-col mb-4">
              <Input
                id="endDate"
                label="End Date"
                type="date"
                value={formik.values.endDate}
                onChange={formik.handleChange}
              />
              {formik.errors.endDate && formik.touched.endDate ? (
                <p className="mt-2 text-xs text-red-500">
                  {formik.errors.endDate}
                </p>
              ) : null}
            </div>
            <div className="flex flex-col mb-4">
              <Input
                id="discountPercent"
                label="Discount Percent"
                type="number"
                placeholder="50..."
                value={formik.values.discountPercent}
                onChange={formik.handleChange}
              />
              {formik.errors.discountPercent &&
              formik.touched.discountPercent ? (
                <p className="mt-2 text-xs text-red-500">
                  {formik.errors.discountPercent}
                </p>
              ) : null}
            </div>
            <div className="flex flex-col mb-4">
              <Input
                id="shopId"
                label="Shop ID"
                type="text"
                value={formik.values.shopId}
                onChange={formik.handleChange}
                disabled
              />
            </div>
            <button
              type="submit"
              className="mt-5 w-full bg-dark-nude text-white rounded-md py-2"
            >
              {item ? "Update Discount" : "Create Discount"}
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};

Modal.propTypes = {
  item: PropTypes.object,
  visible: PropTypes.bool.isRequired,
  onClose: PropTypes.func.isRequired,
  handleAdd: PropTypes.func.isRequired,
  handleUpdate: PropTypes.func.isRequired,
  setCurrentDiscount: PropTypes.func.isRequired,
};

export default Modal;
