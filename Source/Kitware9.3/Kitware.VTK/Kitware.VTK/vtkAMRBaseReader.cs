using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRBaseReader
	/// </summary>
	/// <remarks>
	///    An abstract class that encapsulates common functionality for all AMR readers.
	/// </remarks>
	// Token: 0x02000224 RID: 548
	public abstract class vtkAMRBaseReader : vtkOverlappingAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006724 RID: 26404 RVA: 0x00094D97 File Offset: 0x00092F97
		static vtkAMRBaseReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRBaseReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRBaseReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006725 RID: 26405 RVA: 0x00094DBF File Offset: 0x00092FBF
		public vtkAMRBaseReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006726 RID: 26406 RVA: 0x00094DCD File Offset: 0x00092FCD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006727 RID: 26407
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_EnableCachingOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get Reader caching property
		/// </summary>
		// Token: 0x06006728 RID: 26408 RVA: 0x00094DD8 File Offset: 0x00092FD8
		public virtual void EnableCachingOff()
		{
			vtkAMRBaseReader.vtkAMRBaseReader_EnableCachingOff_01(base.GetCppThis());
		}

		// Token: 0x06006729 RID: 26409
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_EnableCachingOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get Reader caching property
		/// </summary>
		// Token: 0x0600672A RID: 26410 RVA: 0x00094DE7 File Offset: 0x00092FE7
		public virtual void EnableCachingOn()
		{
			vtkAMRBaseReader.vtkAMRBaseReader_EnableCachingOn_02(base.GetCppThis());
		}

		// Token: 0x0600672B RID: 26411
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_GetCellArrayName_03(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x0600672C RID: 26412 RVA: 0x00094DF8 File Offset: 0x00092FF8
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkAMRBaseReader.vtkAMRBaseReader_GetCellArrayName_03(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600672D RID: 26413
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetCellArrayStatus_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x0600672E RID: 26414 RVA: 0x00094E34 File Offset: 0x00093034
		public int GetCellArrayStatus(string name)
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetCellArrayStatus_04(base.GetCppThis(), name);
		}

		// Token: 0x0600672F RID: 26415
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_GetCellDataArraySelection_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06006730 RID: 26416 RVA: 0x00094E54 File Offset: 0x00093054
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseReader.vtkAMRBaseReader_GetCellDataArraySelection_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006731 RID: 26417
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_GetController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get a multiprocess-controller for reading in parallel.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x06006732 RID: 26418 RVA: 0x00094EC4 File Offset: 0x000930C4
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseReader.vtkAMRBaseReader_GetController_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x06006733 RID: 26419
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetEnableCaching_07(HandleRef pThis);

		/// <summary>
		/// Set/Get Reader caching property
		/// </summary>
		// Token: 0x06006734 RID: 26420 RVA: 0x00094F34 File Offset: 0x00093134
		public virtual int GetEnableCaching()
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetEnableCaching_07(base.GetCppThis());
		}

		// Token: 0x06006735 RID: 26421
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_GetFileName_08(HandleRef pThis);

		/// <summary>
		/// Set/Get the filename. Concrete instances of this class must implement
		/// the SetFileName method accordingly.
		/// </summary>
		// Token: 0x06006736 RID: 26422 RVA: 0x00094F54 File Offset: 0x00093154
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkAMRBaseReader.vtkAMRBaseReader_GetFileName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006737 RID: 26423
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetNumberOfBlocks_09(HandleRef pThis);

		/// <summary>
		/// Returns the total number of blocks. Implemented by concrete instances.
		/// </summary>
		// Token: 0x06006738 RID: 26424 RVA: 0x00094F90 File Offset: 0x00093190
		public virtual int GetNumberOfBlocks()
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetNumberOfBlocks_09(base.GetCppThis());
		}

		// Token: 0x06006739 RID: 26425
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetNumberOfCellArrays_10(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x0600673A RID: 26426 RVA: 0x00094FB0 File Offset: 0x000931B0
		public int GetNumberOfCellArrays()
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetNumberOfCellArrays_10(base.GetCppThis());
		}

		// Token: 0x0600673B RID: 26427
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRBaseReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600673C RID: 26428 RVA: 0x00094FD0 File Offset: 0x000931D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x0600673D RID: 26429
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRBaseReader_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600673E RID: 26430 RVA: 0x00094FF0 File Offset: 0x000931F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x0600673F RID: 26431
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetNumberOfLevels_13(HandleRef pThis);

		/// <summary>
		/// Returns the total number of levels. Implemented by concrete instances.
		/// </summary>
		// Token: 0x06006740 RID: 26432 RVA: 0x0009500C File Offset: 0x0009320C
		public virtual int GetNumberOfLevels()
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetNumberOfLevels_13(base.GetCppThis());
		}

		// Token: 0x06006741 RID: 26433
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetNumberOfPointArrays_14(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x06006742 RID: 26434 RVA: 0x0009502C File Offset: 0x0009322C
		public int GetNumberOfPointArrays()
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetNumberOfPointArrays_14(base.GetCppThis());
		}

		// Token: 0x06006743 RID: 26435
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_GetPointArrayName_15(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell array with the given index in
		/// the input.
		/// </summary>
		// Token: 0x06006744 RID: 26436 RVA: 0x0009504C File Offset: 0x0009324C
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkAMRBaseReader.vtkAMRBaseReader_GetPointArrayName_15(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006745 RID: 26437
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_GetPointArrayStatus_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06006746 RID: 26438 RVA: 0x00095088 File Offset: 0x00093288
		public int GetPointArrayStatus(string name)
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_GetPointArrayStatus_16(base.GetCppThis(), name);
		}

		// Token: 0x06006747 RID: 26439
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_GetPointDataArraySelection_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x06006748 RID: 26440 RVA: 0x000950A8 File Offset: 0x000932A8
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseReader.vtkAMRBaseReader_GetPointDataArraySelection_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006749 RID: 26441
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_Initialize_18(HandleRef pThis);

		/// <summary>
		/// Initializes the AMR reader.
		/// All concrete instances must call this method in their constructor.
		/// </summary>
		// Token: 0x0600674A RID: 26442 RVA: 0x00095117 File Offset: 0x00093317
		public void Initialize()
		{
			vtkAMRBaseReader.vtkAMRBaseReader_Initialize_18(base.GetCppThis());
		}

		// Token: 0x0600674B RID: 26443
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_IsA_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600674C RID: 26444 RVA: 0x00095128 File Offset: 0x00093328
		public override int IsA(string type)
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_IsA_19(base.GetCppThis(), type);
		}

		// Token: 0x0600674D RID: 26445
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRBaseReader_IsCachingEnabled_20(HandleRef pThis);

		/// <summary>
		/// Set/Get Reader caching property
		/// </summary>
		// Token: 0x0600674E RID: 26446 RVA: 0x00095148 File Offset: 0x00093348
		public bool IsCachingEnabled()
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_IsCachingEnabled_20(base.GetCppThis()) != 0;
		}

		// Token: 0x0600674F RID: 26447
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRBaseReader_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006750 RID: 26448 RVA: 0x00095170 File Offset: 0x00093370
		public new static int IsTypeOf(string type)
		{
			return vtkAMRBaseReader.vtkAMRBaseReader_IsTypeOf_21(type);
		}

		// Token: 0x06006751 RID: 26449
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006752 RID: 26450 RVA: 0x0009518C File Offset: 0x0009338C
		public new vtkAMRBaseReader NewInstance()
		{
			vtkAMRBaseReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseReader.vtkAMRBaseReader_NewInstance_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRBaseReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006753 RID: 26451
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRBaseReader_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006754 RID: 26452 RVA: 0x000951E8 File Offset: 0x000933E8
		public new static vtkAMRBaseReader SafeDownCast(vtkObjectBase o)
		{
			vtkAMRBaseReader vtkAMRBaseReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRBaseReader.vtkAMRBaseReader_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRBaseReader = (vtkAMRBaseReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRBaseReader.Register(null);
				}
			}
			return vtkAMRBaseReader;
		}

		// Token: 0x06006755 RID: 26453
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_SetCellArrayStatus_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06006756 RID: 26454 RVA: 0x00095267 File Offset: 0x00093467
		public void SetCellArrayStatus(string name, int status)
		{
			vtkAMRBaseReader.vtkAMRBaseReader_SetCellArrayStatus_24(base.GetCppThis(), name, status);
		}

		// Token: 0x06006757 RID: 26455
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_SetController_25(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get a multiprocess-controller for reading in parallel.
		/// By default this parameter is set to nullptr by the constructor.
		/// </summary>
		// Token: 0x06006758 RID: 26456 RVA: 0x00095278 File Offset: 0x00093478
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkAMRBaseReader.vtkAMRBaseReader_SetController_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006759 RID: 26457
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_SetEnableCaching_26(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get Reader caching property
		/// </summary>
		// Token: 0x0600675A RID: 26458 RVA: 0x000952A7 File Offset: 0x000934A7
		public virtual void SetEnableCaching(int _arg)
		{
			vtkAMRBaseReader.vtkAMRBaseReader_SetEnableCaching_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600675B RID: 26459
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_SetFileName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Set/Get the filename. Concrete instances of this class must implement
		/// the SetFileName method accordingly.
		/// </summary>
		// Token: 0x0600675C RID: 26460 RVA: 0x000952B7 File Offset: 0x000934B7
		public virtual void SetFileName(string fileName)
		{
			vtkAMRBaseReader.vtkAMRBaseReader_SetFileName_27(base.GetCppThis(), fileName);
		}

		// Token: 0x0600675D RID: 26461
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_SetMaxLevel_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the level, up to which the blocks are loaded.
		/// </summary>
		// Token: 0x0600675E RID: 26462 RVA: 0x000952C7 File Offset: 0x000934C7
		public virtual void SetMaxLevel(int _arg)
		{
			vtkAMRBaseReader.vtkAMRBaseReader_SetMaxLevel_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600675F RID: 26463
		[DllImport("Kitware.VTK.IOAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRBaseReader_SetPointArrayStatus_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point or cell array with the given name is to
		/// be read.
		/// </summary>
		// Token: 0x06006760 RID: 26464 RVA: 0x000952D7 File Offset: 0x000934D7
		public void SetPointArrayStatus(string name, int status)
		{
			vtkAMRBaseReader.vtkAMRBaseReader_SetPointArrayStatus_29(base.GetCppThis(), name, status);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400092F RID: 2351
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRBaseReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000930 RID: 2352
		public new static readonly string MRClassNameKey = "class vtkAMRBaseReader";
	}
}
