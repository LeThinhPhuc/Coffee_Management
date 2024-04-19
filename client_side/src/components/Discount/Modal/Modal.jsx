import PropType from "prop-types";
import Input from "./Input";
import { useFormik } from "formik";
import * as Yup from "yup";
import { useState, useEffect } from "react";

const Modal = ({
  item,
  visible,
  onClose,
  handleAdd,
  handleUpdate,
  setCurrentDiscount,
}) => {
  const [formikValues, setFormikValues] = useState({
    code: "",
    from: "",
    to: "",
    percent: "",
  });
  // Validation cho form nhập
  const formik = useFormik({
    initialValues: {
      code: "",
      from: "",
      to: "",
      percent: "",
    },
    validationSchema: Yup.object({
      code: Yup.string().required("Required"),
      from: Yup.date().required("Required"),
      to: Yup.date().required("Required"),
      percent: Yup.number("Please enter number")
        .required("Required")
        .min(1, "Percent must be greater than or equal to 1")
        .max(100, "Percent must be less than or equal to 100"),
    }),
    onSubmit: (values) => {
      if (item) {
        handleUpdate({ ...values, id: item.id });
        setCurrentDiscount("");
        window.alert("Updated Discount");
      } else {
        console.log(values);
        handleAdd(values);
        window.alert("Added Discount");
      }
    },
  });

  // nếu tồn tại item thì gán giá trị cho field
  useEffect(() => {
    if (item) {
      setFormikValues((preValues) => ({
        ...preValues,
        code: item.code,
        from: item.from,
        to: item.to,
        percent: item.percent,
      }));
    }
  }, [item]);

  useEffect(() => {
    formik.setValues(formikValues);
  }, [formikValues]);

  if (!visible) return null;
  return (
    <div className=" fixed bg-black inset-0 bg-opacity-30 backdrop-blur-sm flex justify-center items-center">
      <div className="bg-white w-10/12 md:w-5/12 lg:w-4/12 h-4/6 z-auto rounded-2xl mt-10 p-2.5 drop-shadow-2xl ">
        <div className="flex justify-between align-middle px-5 my-3">
          <h3 className="font-medium font-montserrat">
            {" "}
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
                id="code"
                label="Discount Code"
                type="text"
                placeholder="CODEABC..."
                values={formik.values.code}
                onChange={formik.handleChange}
              />
              {formik.errors.code && formik.touched.code && (
                <span className="flex items-center font-medium tracking-wide text-red-500 text-xs mt-1 ml-1">
                  {formik.errors.code}
                </span>
              )}
            </div>
            <div className="flex lg:space-x-9 space-x-4">
              <div className="flex flex-col mb-4">
                <Input
                  id="from"
                  label="From"
                  type="date"
                  values={formik.values.from}
                  onChange={formik.handleChange}
                ></Input>
                {formik.errors.from && formik.touched.from && (
                  <span className="flex items-center font-medium tracking-wide text-red-500 text-xs mt-1 ml-1">
                    {formik.errors.from}
                  </span>
                )}
              </div>
              <div className="flex flex-col mb-4">
                <Input
                  id="to"
                  label="To"
                  type="date"
                  values={formik.values.to}
                  onChange={formik.handleChange}
                ></Input>
                {formik.errors.to && formik.touched.to && (
                  <span className="flex items-center font-medium tracking-wide text-red-500 text-xs mt-1 ml-1">
                    {formik.errors.to}
                  </span>
                )}
              </div>
            </div>
            <div className="flex flex-col mb-4">
              <Input
                id="percent"
                label="Percent"
                type="number"
                placeholder="10"
                values={formik.values.percent}
                onChange={formik.handleChange}
              ></Input>
              {formik.errors.percent && formik.touched.percent && (
                <span className="flex items-center font-medium tracking-wide text-red-500 text-xs mt-1 ml-1">
                  {formik.errors.percent}
                </span>
              )}
            </div>
          </div>
          <div className="flex justify-center">
            <button
              type="submit"
              className="bg-dark-nude rounded-full h-[40px] w-[100px] text-center font-bold mt-5 hover:bg-nude hover:text-white"
            >
              Save
            </button>
          </div>
        </form>
      </div>
    </div>
  );
};

Modal.propTypes = {
  item: PropType.shape({
    id: PropType.number,
    code: PropType.string,
    from: PropType.string,
    to: PropType.string,
    percent: PropType.number,
  }),
  visible: PropType.bool,
  onClose: PropType.func,
  handleAdd: PropType.func,
  handleUpdate: PropType.func,
  setCurrentDiscount: PropType.func,
};

export default Modal;
