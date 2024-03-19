using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///     vtkCONVERGECFDCGNSReader
	/// </summary>
	/// <remarks>
	///     Reader for CONVERGECFD CGNS post files.
	///
	/// This class reads CONVERGECFD post files using the CGNS standard. Meshes,
	/// surfaces, and parcels are read. Parcels are defined inside "PARCEL_DATA"
	/// UserDefinedData_t nodes.
	///
	/// Cell data arrays associated with mesh cells can be individually
	/// selected for reading using the CellArrayStatus API.
	///
	/// Regular point data arrays associated with mesh points can be individually
	/// selected for reading using the PointArrayStatus API.
	///
	/// Point data arrays associated with parcels can be individually selected
	/// for reading using the ParcelArrayStatus API.
	/// </remarks>
	// Token: 0x020001E5 RID: 485
	public class vtkCONVERGECFDCGNSReader : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005C9E RID: 23710 RVA: 0x0008621A File Offset: 0x0008441A
		static vtkCONVERGECFDCGNSReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCONVERGECFDCGNSReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCONVERGECFDCGNSReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005C9F RID: 23711 RVA: 0x00086242 File Offset: 0x00084442
		public vtkCONVERGECFDCGNSReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005CA0 RID: 23712
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDCGNSReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CA1 RID: 23713 RVA: 0x00086250 File Offset: 0x00084450
		public new static vtkCONVERGECFDCGNSReader New()
		{
			vtkCONVERGECFDCGNSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCONVERGECFDCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CA2 RID: 23714 RVA: 0x000862A4 File Offset: 0x000844A4
		public vtkCONVERGECFDCGNSReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005CA3 RID: 23715 RVA: 0x000862E8 File Offset: 0x000844E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005CA4 RID: 23716
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCONVERGECFDCGNSReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Return whether the file can be read with this reader.
		/// Forwarded to the CGNS reader which does the non parcel part of the reading.
		/// </summary>
		// Token: 0x06005CA5 RID: 23717 RVA: 0x000862F4 File Offset: 0x000844F4
		public virtual int CanReadFile(string filename)
		{
			return vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		// Token: 0x06005CA6 RID: 23718
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDCGNSReader_GetCellDataArraySelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the cell data array selection to specify which cell data arrays
		/// should be read. Only the specified arrays will be read from the file.
		/// </summary>
		// Token: 0x06005CA7 RID: 23719 RVA: 0x00086314 File Offset: 0x00084514
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_GetCellDataArraySelection_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005CA8 RID: 23720
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkCONVERGECFDCGNSReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Get/set the CGNS file name.
		/// </summary>
		// Token: 0x06005CA9 RID: 23721 RVA: 0x00086384 File Offset: 0x00084584
		public virtual string GetFileName()
		{
			return vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_GetFileName_03(base.GetCppThis());
		}

		// Token: 0x06005CAA RID: 23722
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCONVERGECFDCGNSReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CAB RID: 23723 RVA: 0x000863A4 File Offset: 0x000845A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06005CAC RID: 23724
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCONVERGECFDCGNSReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CAD RID: 23725 RVA: 0x000863C4 File Offset: 0x000845C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06005CAE RID: 23726
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDCGNSReader_GetParcelDataArraySelection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the parcel data array selection to specify which parcel data arrays
		/// should be read. Only the specified arrays will be read from the file.
		/// Note that parcels are defined as points separate from the main mesh.
		/// </summary>
		// Token: 0x06005CAF RID: 23727 RVA: 0x000863E0 File Offset: 0x000845E0
		public virtual vtkDataArraySelection GetParcelDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_GetParcelDataArraySelection_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005CB0 RID: 23728
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDCGNSReader_GetPointDataArraySelection_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the point data array selection to specify which point data arrays
		/// should be read. Only the specified arrays will be read from the file.
		/// </summary>
		// Token: 0x06005CB1 RID: 23729 RVA: 0x00086450 File Offset: 0x00084650
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_GetPointDataArraySelection_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06005CB2 RID: 23730
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCONVERGECFDCGNSReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CB3 RID: 23731 RVA: 0x000864C0 File Offset: 0x000846C0
		public override int IsA(string type)
		{
			return vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06005CB4 RID: 23732
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCONVERGECFDCGNSReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CB5 RID: 23733 RVA: 0x000864E0 File Offset: 0x000846E0
		public new static int IsTypeOf(string type)
		{
			return vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_IsTypeOf_09(type);
		}

		// Token: 0x06005CB6 RID: 23734
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDCGNSReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CB7 RID: 23735 RVA: 0x000864FC File Offset: 0x000846FC
		public new vtkCONVERGECFDCGNSReader NewInstance()
		{
			vtkCONVERGECFDCGNSReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCONVERGECFDCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005CB8 RID: 23736
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDCGNSReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CB9 RID: 23737 RVA: 0x00086558 File Offset: 0x00084758
		public new static vtkCONVERGECFDCGNSReader SafeDownCast(vtkObjectBase o)
		{
			vtkCONVERGECFDCGNSReader vtkCONVERGECFDCGNSReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCONVERGECFDCGNSReader = (vtkCONVERGECFDCGNSReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCONVERGECFDCGNSReader.Register(null);
				}
			}
			return vtkCONVERGECFDCGNSReader;
		}

		// Token: 0x06005CBA RID: 23738
		[DllImport("Kitware.VTK.IOCGNSReader.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCONVERGECFDCGNSReader_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/set the CGNS file name.
		/// </summary>
		// Token: 0x06005CBB RID: 23739 RVA: 0x000865D7 File Offset: 0x000847D7
		public virtual void SetFileName(string _arg)
		{
			vtkCONVERGECFDCGNSReader.vtkCONVERGECFDCGNSReader_SetFileName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000894 RID: 2196
		public new const string MRFullTypeName = "Kitware.VTK.vtkCONVERGECFDCGNSReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000895 RID: 2197
		public new static readonly string MRClassNameKey = "class vtkCONVERGECFDCGNSReader";
	}
}
