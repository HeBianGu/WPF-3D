using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataReader
	/// </summary>
	/// <remarks>
	///    read vtk polygonal data file
	///
	/// vtkPolyDataReader is a source object that reads ASCII or binary
	/// polygonal data files in vtk format (see text for format details).
	/// The output of this reader is a single vtkPolyData data object.
	/// The superclass of this class, vtkDataReader, provides many methods for
	/// controlling the reading of the data file, see vtkDataReader for more
	/// information.
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyData vtkDataReader
	/// </seealso>
	// Token: 0x0200070C RID: 1804
	public class vtkPolyDataReader : vtkDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012F2E RID: 77614 RVA: 0x001AB84F File Offset: 0x001A9A4F
		static vtkPolyDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012F2F RID: 77615 RVA: 0x001AB877 File Offset: 0x001A9A77
		public vtkPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012F30 RID: 77616
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F31 RID: 77617 RVA: 0x001AB888 File Offset: 0x001A9A88
		public new static vtkPolyDataReader New()
		{
			vtkPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataReader.vtkPolyDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F32 RID: 77618 RVA: 0x001AB8DC File Offset: 0x001A9ADC
		public vtkPolyDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataReader.vtkPolyDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012F33 RID: 77619 RVA: 0x001AB920 File Offset: 0x001A9B20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012F34 RID: 77620
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F35 RID: 77621 RVA: 0x001AB92C File Offset: 0x001A9B2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataReader.vtkPolyDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012F36 RID: 77622
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F37 RID: 77623 RVA: 0x001AB94C File Offset: 0x001A9B4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataReader.vtkPolyDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012F38 RID: 77624
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012F39 RID: 77625 RVA: 0x001AB968 File Offset: 0x001A9B68
		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataReader.vtkPolyDataReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06012F3A RID: 77626
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012F3B RID: 77627 RVA: 0x001AB9D8 File Offset: 0x001A9BD8
		public vtkPolyData GetOutput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataReader.vtkPolyDataReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06012F3C RID: 77628
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F3D RID: 77629 RVA: 0x001ABA48 File Offset: 0x001A9C48
		public override int IsA(string type)
		{
			return vtkPolyDataReader.vtkPolyDataReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012F3E RID: 77630
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F3F RID: 77631 RVA: 0x001ABA68 File Offset: 0x001A9C68
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataReader.vtkPolyDataReader_IsTypeOf_06(type);
		}

		// Token: 0x06012F40 RID: 77632
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F41 RID: 77633 RVA: 0x001ABA84 File Offset: 0x001A9C84
		public new vtkPolyDataReader NewInstance()
		{
			vtkPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataReader.vtkPolyDataReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012F42 RID: 77634
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataReader_ReadMeshSimple_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname, HandleRef output);

		/// <summary>
		/// Actual reading happens here
		/// </summary>
		// Token: 0x06012F43 RID: 77635 RVA: 0x001ABAE0 File Offset: 0x001A9CE0
		public override int ReadMeshSimple(string fname, vtkDataObject output)
		{
			return vtkPolyDataReader.vtkPolyDataReader_ReadMeshSimple_09(base.GetCppThis(), fname, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x06012F44 RID: 77636
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataReader_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012F45 RID: 77637 RVA: 0x001ABB18 File Offset: 0x001A9D18
		public new static vtkPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataReader vtkPolyDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataReader.vtkPolyDataReader_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataReader = (vtkPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataReader.Register(null);
				}
			}
			return vtkPolyDataReader;
		}

		// Token: 0x06012F46 RID: 77638
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataReader_SetOutput_11(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Get the output of this reader.
		/// </summary>
		// Token: 0x06012F47 RID: 77639 RVA: 0x001ABB98 File Offset: 0x001A9D98
		public void SetOutput(vtkPolyData output)
		{
			vtkPolyDataReader.vtkPolyDataReader_SetOutput_11(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015E4 RID: 5604
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015E5 RID: 5605
		public new static readonly string MRClassNameKey = "class vtkPolyDataReader";
	}
}
