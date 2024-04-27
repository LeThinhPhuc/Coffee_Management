import React from "react";

const fakeData = {
  total: 24.7,
  isIncrease: true,
  percent: 49,
};
const Status = () => {
  return (
    <div className="bg-white shadow rounded-lg p-4 sm:p-6 xl:py-3 row-span-1 flex justify-around items-center">
      <div className="flex items-center py-2">
        <div className="mr-10">
          <div className="flex items-center">
            <div className="text-3xl font-bold text-gray-800 mr-2">24.7 Tr</div>
            {fakeData.isIncrease && (
              <div className="text-sm font-medium text-green-500">
                +{fakeData.percent}%
              </div>
            )}
            {!fakeData.isIncrease && (
              <div className="text-sm font-medium text-red-500">
                -{fakeData.percent}%
              </div>
            )}
          </div>
          <div className="text-sm text-gray-500">Tuần vừa qua</div>
        </div>
      </div>
      <div
        className="hidden md:block w-px h-20 bg-gray-200 "
        aria-hidden="true"
      ></div>
      <div className="flex items-center py-2">
        <div className="mr-5">
          <div className="flex items-center">
            <div className="text-3xl font-bold text-gray-800 mr-2">60.2 Tr</div>
            <div className="text-sm font-medium text-yellow-500">-7%</div>
          </div>
          <div className="text-sm text-gray-500">Tháng vừa qua</div>
        </div>
      </div>
    </div>
  );
};

export default Status;
