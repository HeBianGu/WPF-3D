using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPolyDataWriter
	/// </summary>
	/// <remarks>
	///    Write VTK XML PolyData files.
	///
	/// vtkXMLPolyDataWriter writes the VTK XML PolyData file format.  One
	/// polygonal data input can be written into one file in any number of
	/// streamed pieces (if supported by the rest of the pipeline).  The
	/// standard extension for this writer's file format is "vtp".  This
	/// writer is also used to write a single piece of the parallel file
	/// format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPPolyDataWriter
	/// </seealso>
	// Token: 0x020006E2 RID: 1762
	public class vtkXMLPolyDataWriter : vtkXMLUnstructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060129F5 RID: 76277 RVA: 0x001A291B File Offset: 0x001A0B1B
		static vtkXMLPolyDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPolyDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPolyDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060129F6 RID: 76278 RVA: 0x001A2943 File Offset: 0x001A0B43
		public vtkXMLPolyDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060129F7 RID: 76279
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129F8 RID: 76280 RVA: 0x001A2954 File Offset: 0x001A0B54
		public new static vtkXMLPolyDataWriter New()
		{
			vtkXMLPolyDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060129F9 RID: 76281 RVA: 0x001A29A8 File Offset: 0x001A0BA8
		public vtkXMLPolyDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060129FA RID: 76282 RVA: 0x001A29EC File Offset: 0x001A0BEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060129FB RID: 76283
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x060129FC RID: 76284 RVA: 0x001A29F8 File Offset: 0x001A0BF8
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060129FD RID: 76285
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x060129FE RID: 76286 RVA: 0x001A2A34 File Offset: 0x001A0C34
		public new vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060129FF RID: 76287
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A00 RID: 76288 RVA: 0x001A2AA4 File Offset: 0x001A0CA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06012A01 RID: 76289
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPolyDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A02 RID: 76290 RVA: 0x001A2AC4 File Offset: 0x001A0CC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06012A03 RID: 76291
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPolyDataWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A04 RID: 76292 RVA: 0x001A2AE0 File Offset: 0x001A0CE0
		public override int IsA(string type)
		{
			return vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06012A05 RID: 76293
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPolyDataWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A06 RID: 76294 RVA: 0x001A2B00 File Offset: 0x001A0D00
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_IsTypeOf_06(type);
		}

		// Token: 0x06012A07 RID: 76295
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A08 RID: 76296 RVA: 0x001A2B1C File Offset: 0x001A0D1C
		public new vtkXMLPolyDataWriter NewInstance()
		{
			vtkXMLPolyDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012A09 RID: 76297
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPolyDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012A0A RID: 76298 RVA: 0x001A2B78 File Offset: 0x001A0D78
		public new static vtkXMLPolyDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPolyDataWriter vtkXMLPolyDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPolyDataWriter.vtkXMLPolyDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPolyDataWriter = (vtkXMLPolyDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPolyDataWriter.Register(null);
				}
			}
			return vtkXMLPolyDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001575 RID: 5493
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPolyDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001576 RID: 5494
		public new static readonly string MRClassNameKey = "class vtkXMLPolyDataWriter";
	}
}
