using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPUnstructuredGridReader
	/// </summary>
	/// <remarks>
	///    Read PVTK XML UnstructuredGrid files.
	///
	/// vtkXMLPUnstructuredGridReader reads the PVTK XML UnstructuredGrid
	/// file format.  This reads the parallel format's summary file and
	/// then uses vtkXMLUnstructuredGridReader to read data from the
	/// individual UnstructuredGrid piece files.  Streaming is supported.
	/// The standard extension for this reader's file format is "pvtu".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLUnstructuredGridReader
	/// </seealso>
	// Token: 0x020006DC RID: 1756
	public class vtkXMLPUnstructuredGridReader : vtkXMLPUnstructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012969 RID: 76137 RVA: 0x001A19C4 File Offset: 0x0019FBC4
		static vtkXMLPUnstructuredGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601296A RID: 76138 RVA: 0x001A19EC File Offset: 0x0019FBEC
		public vtkXMLPUnstructuredGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601296B RID: 76139
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601296C RID: 76140 RVA: 0x001A19FC File Offset: 0x0019FBFC
		public new static vtkXMLPUnstructuredGridReader New()
		{
			vtkXMLPUnstructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601296D RID: 76141 RVA: 0x001A1A50 File Offset: 0x0019FC50
		public vtkXMLPUnstructuredGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601296E RID: 76142 RVA: 0x001A1A94 File Offset: 0x0019FC94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601296F RID: 76143
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012970 RID: 76144 RVA: 0x001A1AA0 File Offset: 0x0019FCA0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012971 RID: 76145
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPUnstructuredGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012972 RID: 76146 RVA: 0x001A1AC0 File Offset: 0x0019FCC0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012973 RID: 76147
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012974 RID: 76148 RVA: 0x001A1ADC File Offset: 0x0019FCDC
		public vtkUnstructuredGrid GetOutput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012975 RID: 76149
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012976 RID: 76150 RVA: 0x001A1B4C File Offset: 0x0019FD4C
		public vtkUnstructuredGrid GetOutput(int idx)
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06012977 RID: 76151
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012978 RID: 76152 RVA: 0x001A1BBC File Offset: 0x0019FDBC
		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012979 RID: 76153
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPUnstructuredGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601297A RID: 76154 RVA: 0x001A1BDC File Offset: 0x0019FDDC
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_IsTypeOf_06(type);
		}

		// Token: 0x0601297B RID: 76155
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601297C RID: 76156 RVA: 0x001A1BF8 File Offset: 0x0019FDF8
		public new vtkXMLPUnstructuredGridReader NewInstance()
		{
			vtkXMLPUnstructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601297D RID: 76157
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPUnstructuredGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601297E RID: 76158 RVA: 0x001A1C54 File Offset: 0x0019FE54
		public new static vtkXMLPUnstructuredGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredGridReader vtkXMLPUnstructuredGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPUnstructuredGridReader.vtkXMLPUnstructuredGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredGridReader = (vtkXMLPUnstructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredGridReader.Register(null);
				}
			}
			return vtkXMLPUnstructuredGridReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001569 RID: 5481
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400156A RID: 5482
		public new static readonly string MRClassNameKey = "class vtkXMLPUnstructuredGridReader";
	}
}
