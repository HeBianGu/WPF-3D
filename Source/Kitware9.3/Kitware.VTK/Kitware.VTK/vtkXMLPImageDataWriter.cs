using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLPImageDataWriter
	/// </summary>
	/// <remarks>
	///    Write PVTK XML ImageData files.
	///
	/// vtkXMLPImageDataWriter writes the PVTK XML ImageData file format.
	/// One image data input can be written into a parallel file format
	/// with any number of pieces spread across files.  The standard
	/// extension for this writer's file format is "pvti".  This writer
	/// uses vtkXMLImageDataWriter to write the individual piece files.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLImageDataWriter
	/// </seealso>
	// Token: 0x02000147 RID: 327
	public class vtkXMLPImageDataWriter : vtkXMLPStructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003F38 RID: 16184 RVA: 0x0005C84B File Offset: 0x0005AA4B
		static vtkXMLPImageDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPImageDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPImageDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003F39 RID: 16185 RVA: 0x0005C873 File Offset: 0x0005AA73
		public vtkXMLPImageDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003F3A RID: 16186
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F3B RID: 16187 RVA: 0x0005C884 File Offset: 0x0005AA84
		public new static vtkXMLPImageDataWriter New()
		{
			vtkXMLPImageDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPImageDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F3C RID: 16188 RVA: 0x0005C8D8 File Offset: 0x0005AAD8
		public vtkXMLPImageDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003F3D RID: 16189 RVA: 0x0005C91C File Offset: 0x0005AB1C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003F3E RID: 16190
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x06003F3F RID: 16191 RVA: 0x0005C928 File Offset: 0x0005AB28
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003F40 RID: 16192
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x06003F41 RID: 16193 RVA: 0x0005C964 File Offset: 0x0005AB64
		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06003F42 RID: 16194
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPImageDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F43 RID: 16195 RVA: 0x0005C9D4 File Offset: 0x0005ABD4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06003F44 RID: 16196
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLPImageDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F45 RID: 16197 RVA: 0x0005C9F4 File Offset: 0x0005ABF4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06003F46 RID: 16198
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPImageDataWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F47 RID: 16199 RVA: 0x0005CA10 File Offset: 0x0005AC10
		public override int IsA(string type)
		{
			return vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06003F48 RID: 16200
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLPImageDataWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F49 RID: 16201 RVA: 0x0005CA30 File Offset: 0x0005AC30
		public new static int IsTypeOf(string type)
		{
			return vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_IsTypeOf_06(type);
		}

		// Token: 0x06003F4A RID: 16202
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F4B RID: 16203 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		public new vtkXMLPImageDataWriter NewInstance()
		{
			vtkXMLPImageDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPImageDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003F4C RID: 16204
		[DllImport("Kitware.VTK.IOParallelXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLPImageDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003F4D RID: 16205 RVA: 0x0005CAA8 File Offset: 0x0005ACA8
		public new static vtkXMLPImageDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPImageDataWriter vtkXMLPImageDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLPImageDataWriter.vtkXMLPImageDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPImageDataWriter = (vtkXMLPImageDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPImageDataWriter.Register(null);
				}
			}
			return vtkXMLPImageDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D2 RID: 1746
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPImageDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006D3 RID: 1747
		public new static readonly string MRClassNameKey = "class vtkXMLPImageDataWriter";
	}
}
