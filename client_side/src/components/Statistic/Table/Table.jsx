import { Pagination } from "./Pagination";

const Table = () => {
  let billArr = [
    {
      id: 1,
      date: new Date(2024, 3, 2), // tháng 4 phải khai báo là tháng 3 vì tính từ 0
      items: [
        { name: "Bạc Xỉu", quantity: 1, price: 35000 },
        { name: "Cappuchino", quantity: 1, price: 69000 },
        { name: "Trà Sen Vàng", quantity: 1, price: 49000 },
      ],
      total: 153000,
    },
    {
      id: 2,
      date: new Date(2024, 3, 2),
      items: [
        { name: "Trà Thạch Vải", quantity: 1, price: 49000 },
        { name: "Freeze Trà Xanh", quantity: 1, price: 65000 },
        { name: "PhinDi Kem Sữa", quantity: 1, price: 39000 },
      ],
      total: 143000,
    },
  ];
  return (
    <>
      <div className="mb-4 flex items-center justify-between">
        <div>
          <h3 className="text-xl font-bold text-gray-900 mb-2">
            Danh sách hóa đơn
          </h3>
        </div>
        <div className="flex-shrink-0">
          <a
            href="#"
            className="text-sm font-medium text-cyan-600 hover:bg-gray-100 rounded-lg p-2"
          >
            View all
          </a>
        </div>
      </div>
      <div className="flex flex-col mt-8">
        <div className="overflow-x-auto rounded-lg border-2">
          <div className="align-middle inline-block min-w-full">
            <div className="shadow overflow-hidden sm:rounded-lg">
              <table className="min-w-full divide-y divide-gray-200">
                <thead className="bg-gray-50">
                  <tr>
                    <th
                      scope="col"
                      className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                    >
                      ID
                    </th>
                    <th
                      scope="col"
                      className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                    >
                      Ngày lập
                    </th>
                    <th
                      scope="col"
                      className="p-4 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                    >
                      Số tiền
                    </th>
                    <th></th>
                  </tr>
                </thead>
                <tbody className="bg-white">
                  {billArr.map((bill) => (
                    <tr key={bill.id}>
                      <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-900">
                        {bill.id}
                      </td>
                      <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-500">
                        {bill.date.toLocaleDateString("en-GB")}
                      </td>
                      <td className="p-4 whitespace-nowrap text-sm font-normal text-gray-900">
                        {bill.total} VNĐ
                      </td>
                      <td>
                        <a
                          href="#_"
                          className="inline-flex items-center justify-center px-2 py-1 text-sm font-normal leading-6 text-gray-600 whitespace-no-wrap bg-white border border-gray-200 rounded-md shadow-sm hover:bg-gray-50 focus:outline-none focus:shadow-none"
                        >
                          Chi tiết hóa đơn
                        </a>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </table>
            </div>
          </div>
        </div>
        <div className="my-3 flex justify-center ">
          <Pagination />
        </div>
      </div>
    </>
  );
};

export default Table;
