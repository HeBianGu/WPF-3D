using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWindBladeReader
	/// </summary>
	/// <remarks>
	///    class for reading WindBlade data files
	///
	/// vtkWindBladeReader is a source object that reads WindBlade files
	/// which are block binary files with tags before and after each block
	/// giving the number of bytes within the block.  The number of data
	/// variables dumped varies.  There are 3 output ports with the first
	/// being a structured grid with irregular spacing in the Z dimension.
	/// The second is an unstructured grid only read on process 0 and
	/// used to represent the blade.  The third is also a structured grid
	/// with irregular spacing on the Z dimension.  Only the first and
	/// second output ports have time dependent data.
	/// </remarks>
	// Token: 0x02000215 RID: 533
	public class vtkWindBladeReader : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006588 RID: 25992 RVA: 0x00092104 File Offset: 0x00090304
		static vtkWindBladeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindBladeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindBladeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006589 RID: 25993 RVA: 0x0009212C File Offset: 0x0009032C
		public vtkWindBladeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600658A RID: 25994
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600658B RID: 25995 RVA: 0x0009213C File Offset: 0x0009033C
		public new static vtkWindBladeReader New()
		{
			vtkWindBladeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600658C RID: 25996 RVA: 0x00092190 File Offset: 0x00090390
		public vtkWindBladeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWindBladeReader.vtkWindBladeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600658D RID: 25997 RVA: 0x000921D4 File Offset: 0x000903D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600658E RID: 25998
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_DisableAllPointArrays_01(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600658F RID: 25999 RVA: 0x000921DF File Offset: 0x000903DF
		public void DisableAllPointArrays()
		{
			vtkWindBladeReader.vtkWindBladeReader_DisableAllPointArrays_01(base.GetCppThis());
		}

		// Token: 0x06006590 RID: 26000
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_EnableAllPointArrays_02(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x06006591 RID: 26001 RVA: 0x000921EE File Offset: 0x000903EE
		public void EnableAllPointArrays()
		{
			vtkWindBladeReader.vtkWindBladeReader_EnableAllPointArrays_02(base.GetCppThis());
		}

		// Token: 0x06006592 RID: 26002
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetBladeOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output
		/// </summary>
		// Token: 0x06006593 RID: 26003 RVA: 0x00092200 File Offset: 0x00090400
		public vtkUnstructuredGrid GetBladeOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetBladeOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		// Token: 0x06006594 RID: 26004
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetFieldOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output
		/// </summary>
		// Token: 0x06006595 RID: 26005 RVA: 0x00092270 File Offset: 0x00090470
		public vtkStructuredGrid GetFieldOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetFieldOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x06006596 RID: 26006
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetFilename_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006597 RID: 26007 RVA: 0x000922E0 File Offset: 0x000904E0
		public virtual string GetFilename()
		{
			string s = Marshal.PtrToStringAnsi(vtkWindBladeReader.vtkWindBladeReader_GetFilename_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006598 RID: 26008
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetGroundOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output
		/// </summary>
		// Token: 0x06006599 RID: 26009 RVA: 0x0009231C File Offset: 0x0009051C
		public vtkStructuredGrid GetGroundOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetGroundOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		// Token: 0x0600659A RID: 26010
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindBladeReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600659B RID: 26011 RVA: 0x0009238C File Offset: 0x0009058C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWindBladeReader.vtkWindBladeReader_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600659C RID: 26012
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindBladeReader_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600659D RID: 26013 RVA: 0x000923AC File Offset: 0x000905AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWindBladeReader.vtkWindBladeReader_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600659E RID: 26014
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindBladeReader_GetNumberOfPointArrays_09(HandleRef pThis);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x0600659F RID: 26015 RVA: 0x000923C8 File Offset: 0x000905C8
		public int GetNumberOfPointArrays()
		{
			return vtkWindBladeReader.vtkWindBladeReader_GetNumberOfPointArrays_09(base.GetCppThis());
		}

		// Token: 0x060065A0 RID: 26016
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetPointArrayName_10(HandleRef pThis, int index);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x060065A1 RID: 26017 RVA: 0x000923E8 File Offset: 0x000905E8
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkWindBladeReader.vtkWindBladeReader_GetPointArrayName_10(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060065A2 RID: 26018
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindBladeReader_GetPointArrayStatus_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x060065A3 RID: 26019 RVA: 0x00092424 File Offset: 0x00090624
		public int GetPointArrayStatus(string name)
		{
			return vtkWindBladeReader.vtkWindBladeReader_GetPointArrayStatus_11(base.GetCppThis(), name);
		}

		// Token: 0x060065A4 RID: 26020
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetSubExtent_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065A5 RID: 26021 RVA: 0x00092444 File Offset: 0x00090644
		public virtual int[] GetSubExtent()
		{
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetSubExtent_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060065A6 RID: 26022
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_GetSubExtent_13(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065A7 RID: 26023 RVA: 0x0009248C File Offset: 0x0009068C
		public virtual void GetSubExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetSubExtent_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060065A8 RID: 26024
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_GetSubExtent_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065A9 RID: 26025 RVA: 0x000924A4 File Offset: 0x000906A4
		public virtual void GetSubExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetSubExtent_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060065AA RID: 26026
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_GetWholeExtent_15(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065AB RID: 26027 RVA: 0x000924B4 File Offset: 0x000906B4
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_GetWholeExtent_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060065AC RID: 26028
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_GetWholeExtent_16(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065AD RID: 26029 RVA: 0x000924FC File Offset: 0x000906FC
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetWholeExtent_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060065AE RID: 26030
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_GetWholeExtent_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065AF RID: 26031 RVA: 0x00092514 File Offset: 0x00090714
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_GetWholeExtent_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060065B0 RID: 26032
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindBladeReader_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065B1 RID: 26033 RVA: 0x00092524 File Offset: 0x00090724
		public override int IsA(string type)
		{
			return vtkWindBladeReader.vtkWindBladeReader_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x060065B2 RID: 26034
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindBladeReader_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065B3 RID: 26035 RVA: 0x00092544 File Offset: 0x00090744
		public new static int IsTypeOf(string type)
		{
			return vtkWindBladeReader.vtkWindBladeReader_IsTypeOf_19(type);
		}

		// Token: 0x060065B4 RID: 26036
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065B5 RID: 26037 RVA: 0x00092560 File Offset: 0x00090760
		public new vtkWindBladeReader NewInstance()
		{
			vtkWindBladeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060065B6 RID: 26038
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindBladeReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065B7 RID: 26039 RVA: 0x000925BC File Offset: 0x000907BC
		public new static vtkWindBladeReader SafeDownCast(vtkObjectBase o)
		{
			vtkWindBladeReader vtkWindBladeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindBladeReader.vtkWindBladeReader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindBladeReader = (vtkWindBladeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindBladeReader.Register(null);
				}
			}
			return vtkWindBladeReader;
		}

		// Token: 0x060065B8 RID: 26040
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_SetFilename_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065B9 RID: 26041 RVA: 0x0009263B File Offset: 0x0009083B
		public virtual void SetFilename(string _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetFilename_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060065BA RID: 26042
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_SetPointArrayStatus_24(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// The following methods allow selective reading of solutions fields.
		/// By default, ALL data fields on the nodes are read, but this can
		/// be modified.
		/// </summary>
		// Token: 0x060065BB RID: 26043 RVA: 0x0009264B File Offset: 0x0009084B
		public void SetPointArrayStatus(string name, int status)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetPointArrayStatus_24(base.GetCppThis(), name, status);
		}

		// Token: 0x060065BC RID: 26044
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_SetSubExtent_25(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065BD RID: 26045 RVA: 0x0009265C File Offset: 0x0009085C
		public virtual void SetSubExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetSubExtent_25(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x060065BE RID: 26046
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_SetSubExtent_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065BF RID: 26047 RVA: 0x00092674 File Offset: 0x00090874
		public virtual void SetSubExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetSubExtent_26(base.GetCppThis(), _arg);
		}

		// Token: 0x060065C0 RID: 26048
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_SetWholeExtent_27(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065C1 RID: 26049 RVA: 0x00092684 File Offset: 0x00090884
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetWholeExtent_27(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x060065C2 RID: 26050
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindBladeReader_SetWholeExtent_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060065C3 RID: 26051 RVA: 0x0009269C File Offset: 0x0009089C
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkWindBladeReader.vtkWindBladeReader_SetWholeExtent_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400090D RID: 2317
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindBladeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400090E RID: 2318
		public new static readonly string MRClassNameKey = "class vtkWindBladeReader";
	}
}
