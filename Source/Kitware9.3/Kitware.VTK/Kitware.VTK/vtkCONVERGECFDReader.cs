using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///     vtkCONVERGECFDReader
	/// </summary>
	/// <remarks>
	///     Reader for CONVERGE CFD post files.
	///
	/// This class reads CONVERGE CFD post files containing meshes, surfaces,
	/// and parcels. Each stream in a file is read as a top-level
	/// block and meshes, surfaces, and parcels are datasets under
	/// each stream block.
	///
	/// Cell data arrays associated with mesh cells can be individually
	/// selected for reading using the CellArrayStatus API.
	///
	/// Point data arrays associated with parcels can be individually selected
	/// for reading using the ParcelArrayStatus API.
	///
	/// Time series are supported. The reader assumes a time series is defined
	/// in a sequence of files that follow the naming convention
	///
	/// <code>
	/// &lt;prefix&gt;&lt;zero-padded index&gt;[_][&lt;time&gt;].h5
	/// </code>
	///
	/// where the prefix is determined from the FileName property passed to
	/// the reader. The underscore and time elements are optional. The time
	/// value associated with each file is read from metadata in the file.
	///
	/// Parallel data loading is not supported.
	/// </remarks>
	// Token: 0x020001E0 RID: 480
	public class vtkCONVERGECFDReader : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005B4E RID: 23374 RVA: 0x000845C3 File Offset: 0x000827C3
		static vtkCONVERGECFDReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCONVERGECFDReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCONVERGECFDReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005B4F RID: 23375 RVA: 0x000845EB File Offset: 0x000827EB
		public vtkCONVERGECFDReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005B50 RID: 23376
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B51 RID: 23377 RVA: 0x000845FC File Offset: 0x000827FC
		public new static vtkCONVERGECFDReader New()
		{
			vtkCONVERGECFDReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDReader.vtkCONVERGECFDReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCONVERGECFDReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B52 RID: 23378 RVA: 0x00084650 File Offset: 0x00082850
		public vtkCONVERGECFDReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCONVERGECFDReader.vtkCONVERGECFDReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005B53 RID: 23379 RVA: 0x00084694 File Offset: 0x00082894
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005B54 RID: 23380
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCONVERGECFDReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Determine if the file can be read with this reader.
		/// </summary>
		// Token: 0x06005B55 RID: 23381 RVA: 0x000846A0 File Offset: 0x000828A0
		public virtual int CanReadFile(string fname)
		{
			return vtkCONVERGECFDReader.vtkCONVERGECFDReader_CanReadFile_01(base.GetCppThis(), fname);
		}

		// Token: 0x06005B56 RID: 23382
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDReader_GetCellDataArraySelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the cell data array selection to specify which cell data arrays
		/// should be read. Only the specified cell data arrays will be read from the file.
		/// </summary>
		// Token: 0x06005B57 RID: 23383 RVA: 0x000846C0 File Offset: 0x000828C0
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDReader.vtkCONVERGECFDReader_GetCellDataArraySelection_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005B58 RID: 23384
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDReader_GetFileName_03(HandleRef pThis);

		/// <summary>
		/// Specify file name of the Exodus file.
		/// </summary>
		// Token: 0x06005B59 RID: 23385 RVA: 0x00084730 File Offset: 0x00082930
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCONVERGECFDReader.vtkCONVERGECFDReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005B5A RID: 23386
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCONVERGECFDReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B5B RID: 23387 RVA: 0x0008476C File Offset: 0x0008296C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCONVERGECFDReader.vtkCONVERGECFDReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06005B5C RID: 23388
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCONVERGECFDReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B5D RID: 23389 RVA: 0x0008478C File Offset: 0x0008298C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCONVERGECFDReader.vtkCONVERGECFDReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06005B5E RID: 23390
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDReader_GetParcelDataArraySelection_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the parcel data array selection to specify which point data arrays
		/// should be read and associated parcel. Only the specified parcel data arrays will
		/// be read from the file.
		/// </summary>
		// Token: 0x06005B5F RID: 23391 RVA: 0x000847A8 File Offset: 0x000829A8
		public virtual vtkDataArraySelection GetParcelDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDReader.vtkCONVERGECFDReader_GetParcelDataArraySelection_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005B60 RID: 23392
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCONVERGECFDReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B61 RID: 23393 RVA: 0x00084818 File Offset: 0x00082A18
		public override int IsA(string type)
		{
			return vtkCONVERGECFDReader.vtkCONVERGECFDReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06005B62 RID: 23394
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCONVERGECFDReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B63 RID: 23395 RVA: 0x00084838 File Offset: 0x00082A38
		public new static int IsTypeOf(string type)
		{
			return vtkCONVERGECFDReader.vtkCONVERGECFDReader_IsTypeOf_08(type);
		}

		// Token: 0x06005B64 RID: 23396
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B65 RID: 23397 RVA: 0x00084854 File Offset: 0x00082A54
		public new vtkCONVERGECFDReader NewInstance()
		{
			vtkCONVERGECFDReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDReader.vtkCONVERGECFDReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCONVERGECFDReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005B66 RID: 23398
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCONVERGECFDReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005B67 RID: 23399 RVA: 0x000848B0 File Offset: 0x00082AB0
		public new static vtkCONVERGECFDReader SafeDownCast(vtkObjectBase o)
		{
			vtkCONVERGECFDReader vtkCONVERGECFDReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCONVERGECFDReader.vtkCONVERGECFDReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCONVERGECFDReader = (vtkCONVERGECFDReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCONVERGECFDReader.Register(null);
				}
			}
			return vtkCONVERGECFDReader;
		}

		// Token: 0x06005B68 RID: 23400
		[DllImport("Kitware.VTK.IOCONVERGECFD.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCONVERGECFDReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of the Exodus file.
		/// </summary>
		// Token: 0x06005B69 RID: 23401 RVA: 0x0008492F File Offset: 0x00082B2F
		public virtual void SetFileName(string _arg)
		{
			vtkCONVERGECFDReader.vtkCONVERGECFDReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000889 RID: 2185
		public new const string MRFullTypeName = "Kitware.VTK.vtkCONVERGECFDReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400088A RID: 2186
		public new static readonly string MRClassNameKey = "class vtkCONVERGECFDReader";
	}
}
