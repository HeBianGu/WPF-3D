using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPStructuredGridReader
	/// </summary>
	/// <remarks>
	///    Read PVTK XML StructuredGrid files.
	///
	/// vtkXMLPStructuredGridReader reads the PVTK XML StructuredGrid file
	/// format.  This reads the parallel format's summary file and then
	/// uses vtkXMLStructuredGridReader to read data from the individual
	/// StructuredGrid piece files.  Streaming is supported.  The standard
	/// extension for this reader's file format is "pvts".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLStructuredGridReader
	/// </seealso>
	// Token: 0x020006DA RID: 1754
	public class vtkXMLPStructuredGridReader : vtkXMLPStructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012931 RID: 76081 RVA: 0x001A1277 File Offset: 0x0019F477
		static vtkXMLPStructuredGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPStructuredGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPStructuredGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012932 RID: 76082 RVA: 0x001A129F File Offset: 0x0019F49F
		public vtkXMLPStructuredGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012933 RID: 76083
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012934 RID: 76084 RVA: 0x001A12B0 File Offset: 0x0019F4B0
		public new static vtkXMLPStructuredGridReader New()
		{
			vtkXMLPStructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012935 RID: 76085 RVA: 0x001A1304 File Offset: 0x0019F504
		public vtkXMLPStructuredGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012936 RID: 76086 RVA: 0x001A1348 File Offset: 0x0019F548
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012937 RID: 76087
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012938 RID: 76088 RVA: 0x001A1354 File Offset: 0x0019F554
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012939 RID: 76089
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPStructuredGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601293A RID: 76090 RVA: 0x001A1374 File Offset: 0x0019F574
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601293B RID: 76091
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x0601293C RID: 76092 RVA: 0x001A1390 File Offset: 0x0019F590
		public vtkStructuredGrid GetOutput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601293D RID: 76093
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Needed for ParaView
		/// </summary>
		// Token: 0x0601293E RID: 76094 RVA: 0x001A1400 File Offset: 0x0019F600
		public vtkStructuredGrid GetOutput(int idx)
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601293F RID: 76095
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012940 RID: 76096 RVA: 0x001A1470 File Offset: 0x0019F670
		public override int IsA(string type)
		{
			return vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012941 RID: 76097
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPStructuredGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012942 RID: 76098 RVA: 0x001A1490 File Offset: 0x0019F690
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_IsTypeOf_06(type);
		}

		// Token: 0x06012943 RID: 76099
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012944 RID: 76100 RVA: 0x001A14AC File Offset: 0x0019F6AC
		public new vtkXMLPStructuredGridReader NewInstance()
		{
			vtkXMLPStructuredGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012945 RID: 76101
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPStructuredGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012946 RID: 76102 RVA: 0x001A1508 File Offset: 0x0019F708
		public new static vtkXMLPStructuredGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPStructuredGridReader vtkXMLPStructuredGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPStructuredGridReader.vtkXMLPStructuredGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPStructuredGridReader = (vtkXMLPStructuredGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPStructuredGridReader.Register(null);
				}
			}
			return vtkXMLPStructuredGridReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001565 RID: 5477
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPStructuredGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001566 RID: 5478
		public new static readonly string MRClassNameKey = "class vtkXMLPStructuredGridReader";
	}
}
