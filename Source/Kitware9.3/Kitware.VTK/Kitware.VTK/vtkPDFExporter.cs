using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPDFExporter
	/// </summary>
	/// <remarks>
	///  Exports vtkContext2D scenes to PDF.
	///
	/// This exporter draws context2D scenes into a PDF file.
	///
	/// If ActiveRenderer is specified then it exports contents of
	/// ActiveRenderer. Otherwise it exports contents of all renderers.
	/// </remarks>
	// Token: 0x020001AC RID: 428
	public class vtkPDFExporter : vtkExporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060052D7 RID: 21207 RVA: 0x00078CA5 File Offset: 0x00076EA5
		static vtkPDFExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPDFExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPDFExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060052D8 RID: 21208 RVA: 0x00078CCD File Offset: 0x00076ECD
		public vtkPDFExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060052D9 RID: 21209
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDFExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052DA RID: 21210 RVA: 0x00078CDC File Offset: 0x00076EDC
		public new static vtkPDFExporter New()
		{
			vtkPDFExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDFExporter.vtkPDFExporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDFExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052DB RID: 21211 RVA: 0x00078D30 File Offset: 0x00076F30
		public vtkPDFExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPDFExporter.vtkPDFExporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060052DC RID: 21212 RVA: 0x00078D74 File Offset: 0x00076F74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060052DD RID: 21213
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDFExporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The name of the exported file. @{ 
		/// </summary>
		// Token: 0x060052DE RID: 21214 RVA: 0x00078D80 File Offset: 0x00076F80
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkPDFExporter.vtkPDFExporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060052DF RID: 21215
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDFExporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052E0 RID: 21216 RVA: 0x00078DBC File Offset: 0x00076FBC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPDFExporter.vtkPDFExporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060052E1 RID: 21217
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPDFExporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052E2 RID: 21218 RVA: 0x00078DDC File Offset: 0x00076FDC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPDFExporter.vtkPDFExporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060052E3 RID: 21219
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDFExporter_GetTitle_04(HandleRef pThis);

		/// <summary>
		/// The title of the exported document. @{ 
		/// </summary>
		// Token: 0x060052E4 RID: 21220 RVA: 0x00078DF8 File Offset: 0x00076FF8
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkPDFExporter.vtkPDFExporter_GetTitle_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060052E5 RID: 21221
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDFExporter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052E6 RID: 21222 RVA: 0x00078E34 File Offset: 0x00077034
		public override int IsA(string type)
		{
			return vtkPDFExporter.vtkPDFExporter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060052E7 RID: 21223
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPDFExporter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052E8 RID: 21224 RVA: 0x00078E54 File Offset: 0x00077054
		public new static int IsTypeOf(string type)
		{
			return vtkPDFExporter.vtkPDFExporter_IsTypeOf_06(type);
		}

		// Token: 0x060052E9 RID: 21225
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDFExporter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052EA RID: 21226 RVA: 0x00078E70 File Offset: 0x00077070
		public new vtkPDFExporter NewInstance()
		{
			vtkPDFExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDFExporter.vtkPDFExporter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPDFExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060052EB RID: 21227
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPDFExporter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052EC RID: 21228 RVA: 0x00078ECC File Offset: 0x000770CC
		public new static vtkPDFExporter SafeDownCast(vtkObjectBase o)
		{
			vtkPDFExporter vtkPDFExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPDFExporter.vtkPDFExporter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPDFExporter = (vtkPDFExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPDFExporter.Register(null);
				}
			}
			return vtkPDFExporter;
		}

		// Token: 0x060052ED RID: 21229
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDFExporter_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the exported file. @{ 
		/// </summary>
		// Token: 0x060052EE RID: 21230 RVA: 0x00078F4B File Offset: 0x0007714B
		public virtual void SetFileName(string _arg)
		{
			vtkPDFExporter.vtkPDFExporter_SetFileName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060052EF RID: 21231
		[DllImport("Kitware.VTK.IOExportPDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPDFExporter_SetTitle_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The title of the exported document. @{ 
		/// </summary>
		// Token: 0x060052F0 RID: 21232 RVA: 0x00078F5B File Offset: 0x0007715B
		public virtual void SetTitle(string _arg)
		{
			vtkPDFExporter.vtkPDFExporter_SetTitle_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007BD RID: 1981
		public new const string MRFullTypeName = "Kitware.VTK.vtkPDFExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007BE RID: 1982
		public new static readonly string MRClassNameKey = "class vtkPDFExporter";
	}
}
