using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetCDFUGRIDeader
	/// </summary>
	/// <remarks>
	///    Read unstructured NetCDF UGRID files.
	///
	/// This reader read a single 2D mesh for a NetCDF UGRID. It will extract points and cells
	/// but not edges. Temporal datasets are supported as long as the "time" variable exists in the file.
	/// Supported point types are float and double.
	/// Supported cell types are triangle and quad.
	/// Supported data array types are [u]int[8/16/32/64], float and double.
	/// </remarks>
	// Token: 0x02000173 RID: 371
	public class vtkNetCDFUGRIDReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060046D8 RID: 18136 RVA: 0x0006701E File Offset: 0x0006521E
		static vtkNetCDFUGRIDReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetCDFUGRIDReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFUGRIDReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060046D9 RID: 18137 RVA: 0x00067046 File Offset: 0x00065246
		public vtkNetCDFUGRIDReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060046DA RID: 18138
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046DB RID: 18139 RVA: 0x00067054 File Offset: 0x00065254
		public new static vtkNetCDFUGRIDReader New()
		{
			vtkNetCDFUGRIDReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFUGRIDReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046DC RID: 18140 RVA: 0x000670A8 File Offset: 0x000652A8
		public vtkNetCDFUGRIDReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060046DD RID: 18141 RVA: 0x000670EC File Offset: 0x000652EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060046DE RID: 18142
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_GetCellArrayName_01(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell with the given index in the input.
		/// </summary>
		// Token: 0x060046DF RID: 18143 RVA: 0x000670F8 File Offset: 0x000652F8
		public string GetCellArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetCellArrayName_01(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060046E0 RID: 18144
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFUGRIDReader_GetCellArrayStatus_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point or cell with the given name is to be read.
		/// </summary>
		// Token: 0x060046E1 RID: 18145 RVA: 0x00067134 File Offset: 0x00065334
		public int GetCellArrayStatus(string name)
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetCellArrayStatus_02(base.GetCppThis(), name);
		}

		// Token: 0x060046E2 RID: 18146
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_GetCellDataArraySelection_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x060046E3 RID: 18147 RVA: 0x00067154 File Offset: 0x00065354
		public virtual vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetCellDataArraySelection_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060046E4 RID: 18148
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the file name of the file.
		/// </summary>
		// Token: 0x060046E5 RID: 18149 RVA: 0x000671C4 File Offset: 0x000653C4
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060046E6 RID: 18150
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFUGRIDReader_GetNumberOfCellArrays_05(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x060046E7 RID: 18151 RVA: 0x00067200 File Offset: 0x00065400
		public int GetNumberOfCellArrays()
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetNumberOfCellArrays_05(base.GetCppThis());
		}

		// Token: 0x060046E8 RID: 18152
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFUGRIDReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046E9 RID: 18153 RVA: 0x00067220 File Offset: 0x00065420
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x060046EA RID: 18154
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetCDFUGRIDReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046EB RID: 18155 RVA: 0x00067240 File Offset: 0x00065440
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x060046EC RID: 18156
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFUGRIDReader_GetNumberOfPointArrays_08(HandleRef pThis);

		/// <summary>
		/// Get the number of point or cell arrays available in the input.
		/// </summary>
		// Token: 0x060046ED RID: 18157 RVA: 0x0006725C File Offset: 0x0006545C
		public int GetNumberOfPointArrays()
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetNumberOfPointArrays_08(base.GetCppThis());
		}

		// Token: 0x060046EE RID: 18158
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_GetPointArrayName_09(HandleRef pThis, int index);

		/// <summary>
		/// Get the name of the point or cell with the given index in the input.
		/// </summary>
		// Token: 0x060046EF RID: 18159 RVA: 0x0006727C File Offset: 0x0006547C
		public string GetPointArrayName(int index)
		{
			string s = Marshal.PtrToStringAnsi(vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetPointArrayName_09(base.GetCppThis(), index));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060046F0 RID: 18160
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFUGRIDReader_GetPointArrayStatus_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set whether the point or cell with the given name is to be read.
		/// </summary>
		// Token: 0x060046F1 RID: 18161 RVA: 0x000672B8 File Offset: 0x000654B8
		public int GetPointArrayStatus(string name)
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetPointArrayStatus_10(base.GetCppThis(), name);
		}

		// Token: 0x060046F2 RID: 18162
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_GetPointDataArraySelection_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data array selection tables used to configure which data
		/// arrays are loaded by the reader.
		/// </summary>
		// Token: 0x060046F3 RID: 18163 RVA: 0x000672D8 File Offset: 0x000654D8
		public virtual vtkDataArraySelection GetPointDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetPointDataArraySelection_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060046F4 RID: 18164
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkNetCDFUGRIDReader_GetReplaceFillValueWithNan_12(HandleRef pThis);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x060046F5 RID: 18165 RVA: 0x00067348 File Offset: 0x00065548
		public virtual bool GetReplaceFillValueWithNan()
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_GetReplaceFillValueWithNan_12(base.GetCppThis()) != 0;
		}

		// Token: 0x060046F6 RID: 18166
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFUGRIDReader_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046F7 RID: 18167 RVA: 0x00067370 File Offset: 0x00065570
		public override int IsA(string type)
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x060046F8 RID: 18168
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetCDFUGRIDReader_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046F9 RID: 18169 RVA: 0x00067390 File Offset: 0x00065590
		public new static int IsTypeOf(string type)
		{
			return vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_IsTypeOf_14(type);
		}

		// Token: 0x060046FA RID: 18170
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060046FB RID: 18171 RVA: 0x000673AC File Offset: 0x000655AC
		public new vtkNetCDFUGRIDReader NewInstance()
		{
			vtkNetCDFUGRIDReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetCDFUGRIDReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060046FC RID: 18172
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFUGRIDReader_ReplaceFillValueWithNanOff_17(HandleRef pThis);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x060046FD RID: 18173 RVA: 0x00067406 File Offset: 0x00065606
		public virtual void ReplaceFillValueWithNanOff()
		{
			vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_ReplaceFillValueWithNanOff_17(base.GetCppThis());
		}

		// Token: 0x060046FE RID: 18174
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFUGRIDReader_ReplaceFillValueWithNanOn_18(HandleRef pThis);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x060046FF RID: 18175 RVA: 0x00067415 File Offset: 0x00065615
		public virtual void ReplaceFillValueWithNanOn()
		{
			vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_ReplaceFillValueWithNanOn_18(base.GetCppThis());
		}

		// Token: 0x06004700 RID: 18176
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetCDFUGRIDReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004701 RID: 18177 RVA: 0x00067424 File Offset: 0x00065624
		public new static vtkNetCDFUGRIDReader SafeDownCast(vtkObjectBase o)
		{
			vtkNetCDFUGRIDReader vtkNetCDFUGRIDReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetCDFUGRIDReader = (vtkNetCDFUGRIDReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetCDFUGRIDReader.Register(null);
				}
			}
			return vtkNetCDFUGRIDReader;
		}

		// Token: 0x06004702 RID: 18178
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFUGRIDReader_SetCellArrayStatus_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point or cell with the given name is to be read.
		/// </summary>
		// Token: 0x06004703 RID: 18179 RVA: 0x000674A3 File Offset: 0x000656A3
		public void SetCellArrayStatus(string name, int status)
		{
			vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_SetCellArrayStatus_20(base.GetCppThis(), name, status);
		}

		// Token: 0x06004704 RID: 18180
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFUGRIDReader_SetFileName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the file name of the file.
		/// </summary>
		// Token: 0x06004705 RID: 18181 RVA: 0x000674B4 File Offset: 0x000656B4
		public virtual void SetFileName(string _arg)
		{
			vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_SetFileName_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06004706 RID: 18182
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFUGRIDReader_SetPointArrayStatus_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, int status);

		/// <summary>
		/// Get/Set whether the point or cell with the given name is to be read.
		/// </summary>
		// Token: 0x06004707 RID: 18183 RVA: 0x000674C4 File Offset: 0x000656C4
		public void SetPointArrayStatus(string name, int status)
		{
			vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_SetPointArrayStatus_22(base.GetCppThis(), name, status);
		}

		// Token: 0x06004708 RID: 18184
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetCDFUGRIDReader_SetReplaceFillValueWithNan_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on, any float or double variable read that has a _FillValue attribute
		/// will have that fill value replaced with a not-a-number (NaN) value.  The
		/// advantage of setting these to NaN values is that, if implemented properly
		/// by the system and careful math operations are used, they can implicitly be
		/// ignored by calculations like finding the range of the values.  That said,
		/// this option should be used with caution as VTK does not fully support NaN
		/// values and therefore odd calculations may occur.  By default this is off.
		/// </summary>
		// Token: 0x06004709 RID: 18185 RVA: 0x000674D5 File Offset: 0x000656D5
		public virtual void SetReplaceFillValueWithNan(bool _arg)
		{
			vtkNetCDFUGRIDReader.vtkNetCDFUGRIDReader_SetReplaceFillValueWithNan_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000735 RID: 1845
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFUGRIDReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000736 RID: 1846
		public new static readonly string MRClassNameKey = "class vtkNetCDFUGRIDReader";
	}
}
