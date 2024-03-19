using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetCDFPOPReader
	/// </summary>
	/// <remarks>
	///    read NetCDF files
	/// .Author Joshua Wu 09.15.2009
	///
	/// vtkNetCDFPOPReader is a source object that reads NetCDF files.
	/// It should be able to read most any NetCDF file that wants to output a
	/// rectilinear grid.  The ordering of the variables is changed such that
	/// the NetCDF x, y, z directions correspond to the vtkRectilinearGrid
	/// z, y, x directions, respectively.  The striding is done with
	/// respect to the vtkRectilinearGrid ordering.  Additionally, the
	/// z coordinates of the vtkRectilinearGrid are negated so that the
	/// first slice/plane has the highest z-value and the last slice/plane
	/// has the lowest z-value.
	/// </remarks>
	// Token: 0x02000172 RID: 370
	public class vtkNetCDFPOPReader : vtkRectilinearGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060046B0 RID: 18096 RVA: 0x00066C87 File Offset: 0x00064E87
		static vtkNetCDFPOPReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFPOPReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFPOPReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060046B1 RID: 18097 RVA: 0x00066CAF File Offset: 0x00064EAF
		public vtkNetCDFPOPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060046B2 RID: 18098
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFPOPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046B3 RID: 18099 RVA: 0x00066CC0 File Offset: 0x00064EC0
		public new static vtkNetCDFPOPReader New()
		{
			vtkNetCDFPOPReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046B4 RID: 18100 RVA: 0x00066D14 File Offset: 0x00064F14
		public vtkNetCDFPOPReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetCDFPOPReader.vtkNetCDFPOPReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060046B5 RID: 18101 RVA: 0x00066D58 File Offset: 0x00064F58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060046B6 RID: 18102
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFPOPReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The file to open
		/// </summary>
		// Token: 0x060046B7 RID: 18103 RVA: 0x00066D64 File Offset: 0x00064F64
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060046B8 RID: 18104
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFPOPReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046B9 RID: 18105 RVA: 0x00066DA0 File Offset: 0x00064FA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060046BA RID: 18106
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFPOPReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046BB RID: 18107 RVA: 0x00066DC0 File Offset: 0x00064FC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060046BC RID: 18108
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFPOPReader_GetNumberOfVariableArrays_04(HandleRef pThis);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x060046BD RID: 18109 RVA: 0x00066DDC File Offset: 0x00064FDC
		public virtual int GetNumberOfVariableArrays()
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetNumberOfVariableArrays_04(base.GetCppThis());
		}

		// Token: 0x060046BE RID: 18110
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFPOPReader_GetStride_05(HandleRef pThis);

		/// <summary>
		/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
		/// </summary>
		// Token: 0x060046BF RID: 18111 RVA: 0x00066DFC File Offset: 0x00064FFC
		public virtual int[] GetStride()
		{
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetStride_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060046C0 RID: 18112
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFPOPReader_GetStride_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
		/// </summary>
		// Token: 0x060046C1 RID: 18113 RVA: 0x00066E44 File Offset: 0x00065044
		public virtual void GetStride(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetStride_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x060046C2 RID: 18114
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFPOPReader_GetStride_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
		/// </summary>
		// Token: 0x060046C3 RID: 18115 RVA: 0x00066E56 File Offset: 0x00065056
		public virtual void GetStride(IntPtr _arg)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetStride_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060046C4 RID: 18116
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFPOPReader_GetVariableArrayName_08(HandleRef pThis, int index);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x060046C5 RID: 18117 RVA: 0x00066E68 File Offset: 0x00065068
		public virtual string GetVariableArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetVariableArrayName_08(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060046C6 RID: 18118
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFPOPReader_GetVariableArrayStatus_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x060046C7 RID: 18119 RVA: 0x00066EA4 File Offset: 0x000650A4
		public virtual int GetVariableArrayStatus(string name)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_GetVariableArrayStatus_09(base.GetCppThis(), name);
		}

		// Token: 0x060046C8 RID: 18120
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFPOPReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046C9 RID: 18121 RVA: 0x00066EC4 File Offset: 0x000650C4
		public override int IsA(string type)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060046CA RID: 18122
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFPOPReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046CB RID: 18123 RVA: 0x00066EE4 File Offset: 0x000650E4
		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFPOPReader.vtkNetCDFPOPReader_IsTypeOf_11(type);
		}

		// Token: 0x060046CC RID: 18124
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFPOPReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046CD RID: 18125 RVA: 0x00066F00 File Offset: 0x00065100
		public new vtkNetCDFPOPReader NewInstance()
		{
			vtkNetCDFPOPReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060046CE RID: 18126
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFPOPReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046CF RID: 18127 RVA: 0x00066F5C File Offset: 0x0006515C
		public new static vtkNetCDFPOPReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFPOPReader vtkNetCDFPOPReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFPOPReader.vtkNetCDFPOPReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFPOPReader = (vtkNetCDFPOPReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFPOPReader.Register(null);
				}
			}
			return vtkNetCDFPOPReader;
		}

		// Token: 0x060046D0 RID: 18128
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFPOPReader_SetFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The file to open
		/// </summary>
		// Token: 0x060046D1 RID: 18129 RVA: 0x00066FDB File Offset: 0x000651DB
		public virtual void SetFileName(string _arg)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetFileName_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060046D2 RID: 18130
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFPOPReader_SetStride_16(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		/// <summary>
		/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
		/// </summary>
		// Token: 0x060046D3 RID: 18131 RVA: 0x00066FEB File Offset: 0x000651EB
		public virtual void SetStride(int _arg1, int _arg2, int _arg3)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetStride_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060046D4 RID: 18132
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFPOPReader_SetStride_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Enable subsampling in i,j and k dimensions in the vtkRectilinearGrid
		/// </summary>
		// Token: 0x060046D5 RID: 18133 RVA: 0x00066FFD File Offset: 0x000651FD
		public virtual void SetStride(IntPtr _arg)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetStride_17(base.GetCppThis(), _arg);
		}

		// Token: 0x060046D6 RID: 18134
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFPOPReader_SetVariableArrayStatus_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Variable array selection.
		/// </summary>
		// Token: 0x060046D7 RID: 18135 RVA: 0x0006700D File Offset: 0x0006520D
		public virtual void SetVariableArrayStatus(string name, int status)
		{
			vtkNetCDFPOPReader.vtkNetCDFPOPReader_SetVariableArrayStatus_18(base.GetCppThis(), name, status);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000733 RID: 1843
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFPOPReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000734 RID: 1844
		public new static readonly string MRClassNameKey = "class vtkNetCDFPOPReader";
	}
}
