using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPolyDataReader
	/// </summary>
	/// <remarks>
	///    Read VTK XML PolyData files.
	///
	/// vtkXMLPolyDataReader reads the VTK XML PolyData file format.  One
	/// polygonal data file can be read to produce one output.  Streaming
	/// is supported.  The standard extension for this reader's file format
	/// is "vtp".  This reader is also used to read a single piece of the
	/// parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPPolyDataReader
	/// </seealso>
	// Token: 0x020006E0 RID: 1760
	public class vtkXMLPolyDataReader : vtkXMLUnstructuredDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060129BC RID: 76220 RVA: 0x001A2369 File Offset: 0x001A0569
		static vtkXMLPolyDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPolyDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPolyDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060129BD RID: 76221 RVA: 0x001A2391 File Offset: 0x001A0591
		public vtkXMLPolyDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060129BE RID: 76222
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129BF RID: 76223 RVA: 0x001A23A0 File Offset: 0x001A05A0
		public new static vtkXMLPolyDataReader New()
		{
			vtkXMLPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129C0 RID: 76224 RVA: 0x001A23F4 File Offset: 0x001A05F4
		public vtkXMLPolyDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPolyDataReader.vtkXMLPolyDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060129C1 RID: 76225 RVA: 0x001A2438 File Offset: 0x001A0638
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060129C2 RID: 76226
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129C3 RID: 76227 RVA: 0x001A2444 File Offset: 0x001A0644
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060129C4 RID: 76228
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129C5 RID: 76229 RVA: 0x001A2464 File Offset: 0x001A0664
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060129C6 RID: 76230
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfLines_03(HandleRef pThis);

		/// <summary>
		/// Get the number of verts/lines/strips/polys in the output.
		/// </summary>
		// Token: 0x060129C7 RID: 76231 RVA: 0x001A2480 File Offset: 0x001A0680
		public virtual long GetNumberOfLines()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfLines_03(base.GetCppThis());
		}

		// Token: 0x060129C8 RID: 76232
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfPolys_04(HandleRef pThis);

		/// <summary>
		/// Get the number of verts/lines/strips/polys in the output.
		/// </summary>
		// Token: 0x060129C9 RID: 76233 RVA: 0x001A24A0 File Offset: 0x001A06A0
		public virtual long GetNumberOfPolys()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfPolys_04(base.GetCppThis());
		}

		// Token: 0x060129CA RID: 76234
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfStrips_05(HandleRef pThis);

		/// <summary>
		/// Get the number of verts/lines/strips/polys in the output.
		/// </summary>
		// Token: 0x060129CB RID: 76235 RVA: 0x001A24C0 File Offset: 0x001A06C0
		public virtual long GetNumberOfStrips()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfStrips_05(base.GetCppThis());
		}

		// Token: 0x060129CC RID: 76236
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataReader_GetNumberOfVerts_06(HandleRef pThis);

		/// <summary>
		/// Get the number of verts/lines/strips/polys in the output.
		/// </summary>
		// Token: 0x060129CD RID: 76237 RVA: 0x001A24E0 File Offset: 0x001A06E0
		public virtual long GetNumberOfVerts()
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetNumberOfVerts_06(base.GetCppThis());
		}

		// Token: 0x060129CE RID: 76238
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataReader_GetOutput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x060129CF RID: 76239 RVA: 0x001A2500 File Offset: 0x001A0700
		public vtkPolyData GetOutput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetOutput_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060129D0 RID: 76240
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataReader_GetOutput_08(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the reader's output.
		/// </summary>
		// Token: 0x060129D1 RID: 76241 RVA: 0x001A2570 File Offset: 0x001A0770
		public vtkPolyData GetOutput(int idx)
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_GetOutput_08(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060129D2 RID: 76242
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPolyDataReader_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129D3 RID: 76243 RVA: 0x001A25E0 File Offset: 0x001A07E0
		public override int IsA(string type)
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060129D4 RID: 76244
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPolyDataReader_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129D5 RID: 76245 RVA: 0x001A2600 File Offset: 0x001A0800
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPolyDataReader.vtkXMLPolyDataReader_IsTypeOf_10(type);
		}

		// Token: 0x060129D6 RID: 76246
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129D7 RID: 76247 RVA: 0x001A261C File Offset: 0x001A081C
		public new vtkXMLPolyDataReader NewInstance()
		{
			vtkXMLPolyDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060129D8 RID: 76248
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129D9 RID: 76249 RVA: 0x001A2678 File Offset: 0x001A0878
		public new static vtkXMLPolyDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPolyDataReader vtkXMLPolyDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataReader.vtkXMLPolyDataReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPolyDataReader = (vtkXMLPolyDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPolyDataReader.Register(null);
				}
			}
			return vtkXMLPolyDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001571 RID: 5489
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPolyDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001572 RID: 5490
		public new static readonly string MRClassNameKey = "class vtkXMLPolyDataReader";
	}
}
