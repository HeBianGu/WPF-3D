using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPRectilinearGridReader
	/// </summary>
	/// <remarks>
	///    Read PVTK XML RectilinearGrid files.
	///
	/// vtkXMLPRectilinearGridReader reads the PVTK XML RectilinearGrid
	/// file format.  This reads the parallel format's summary file and
	/// then uses vtkXMLRectilinearGridReader to read data from the
	/// individual RectilinearGrid piece files.  Streaming is supported.
	/// The standard extension for this reader's file format is "pvtr".
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLRectilinearGridReader
	/// </seealso>
	// Token: 0x020006D9 RID: 1753
	public class vtkXMLPRectilinearGridReader : vtkXMLPStructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601291B RID: 76059 RVA: 0x001A0F67 File Offset: 0x0019F167
		static vtkXMLPRectilinearGridReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPRectilinearGridReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPRectilinearGridReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601291C RID: 76060 RVA: 0x001A0F8F File Offset: 0x0019F18F
		public vtkXMLPRectilinearGridReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601291D RID: 76061
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601291E RID: 76062 RVA: 0x001A0FA0 File Offset: 0x0019F1A0
		public new static vtkXMLPRectilinearGridReader New()
		{
			vtkXMLPRectilinearGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601291F RID: 76063 RVA: 0x001A0FF4 File Offset: 0x0019F1F4
		public vtkXMLPRectilinearGridReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012920 RID: 76064 RVA: 0x001A1038 File Offset: 0x0019F238
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012921 RID: 76065
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPRectilinearGridReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012922 RID: 76066 RVA: 0x001A1044 File Offset: 0x0019F244
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012923 RID: 76067
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012924 RID: 76068 RVA: 0x001A1064 File Offset: 0x0019F264
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012925 RID: 76069
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridReader_GetOutput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012926 RID: 76070 RVA: 0x001A1080 File Offset: 0x0019F280
		public vtkRectilinearGrid GetOutput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_GetOutput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06012927 RID: 76071
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridReader_GetOutput_04(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x06012928 RID: 76072 RVA: 0x001A10F0 File Offset: 0x0019F2F0
		public vtkRectilinearGrid GetOutput(int idx)
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_GetOutput_04(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		// Token: 0x06012929 RID: 76073
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPRectilinearGridReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601292A RID: 76074 RVA: 0x001A1160 File Offset: 0x0019F360
		public override int IsA(string type)
		{
			return vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601292B RID: 76075
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPRectilinearGridReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601292C RID: 76076 RVA: 0x001A1180 File Offset: 0x0019F380
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_IsTypeOf_06(type);
		}

		// Token: 0x0601292D RID: 76077
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601292E RID: 76078 RVA: 0x001A119C File Offset: 0x0019F39C
		public new vtkXMLPRectilinearGridReader NewInstance()
		{
			vtkXMLPRectilinearGridReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601292F RID: 76079
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPRectilinearGridReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012930 RID: 76080 RVA: 0x001A11F8 File Offset: 0x0019F3F8
		public new static vtkXMLPRectilinearGridReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPRectilinearGridReader vtkXMLPRectilinearGridReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPRectilinearGridReader.vtkXMLPRectilinearGridReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPRectilinearGridReader = (vtkXMLPRectilinearGridReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPRectilinearGridReader.Register(null);
				}
			}
			return vtkXMLPRectilinearGridReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001563 RID: 5475
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPRectilinearGridReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001564 RID: 5476
		public new static readonly string MRClassNameKey = "class vtkXMLPRectilinearGridReader";
	}
}
