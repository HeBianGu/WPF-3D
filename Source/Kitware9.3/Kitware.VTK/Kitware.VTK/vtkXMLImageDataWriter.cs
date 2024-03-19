using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLImageDataWriter
	/// </summary>
	/// <remarks>
	///    Write VTK XML ImageData files.
	///
	/// vtkXMLImageDataWriter writes the VTK XML ImageData file format.
	/// One image data input can be written into one file in any number of
	/// streamed pieces.  The standard extension for this writer's file
	/// format is "vti".  This writer is also used to write a single piece
	/// of the parallel file format.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkXMLPImageDataWriter
	/// </seealso>
	// Token: 0x020006D2 RID: 1746
	public class vtkXMLImageDataWriter : vtkXMLStructuredDataWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012893 RID: 75923 RVA: 0x0019FF3B File Offset: 0x0019E13B
		static vtkXMLImageDataWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLImageDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLImageDataWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012894 RID: 75924 RVA: 0x0019FF63 File Offset: 0x0019E163
		public vtkXMLImageDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012895 RID: 75925
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012896 RID: 75926 RVA: 0x0019FF74 File Offset: 0x0019E174
		public new static vtkXMLImageDataWriter New()
		{
			vtkXMLImageDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataWriter.vtkXMLImageDataWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLImageDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012897 RID: 75927 RVA: 0x0019FFC8 File Offset: 0x0019E1C8
		public vtkXMLImageDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLImageDataWriter.vtkXMLImageDataWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012898 RID: 75928 RVA: 0x001A000C File Offset: 0x0019E20C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012899 RID: 75929
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		/// <summary>
		/// Get the default file extension for files written by this writer.
		/// </summary>
		// Token: 0x0601289A RID: 75930 RVA: 0x001A0018 File Offset: 0x0019E218
		public override string GetDefaultFileExtension()
		{
			string s = Marshal.PtrToStringAnsi(vtkXMLImageDataWriter.vtkXMLImageDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601289B RID: 75931
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataWriter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the writer's input.
		/// </summary>
		// Token: 0x0601289C RID: 75932 RVA: 0x001A0054 File Offset: 0x0019E254
		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataWriter.vtkXMLImageDataWriter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601289D RID: 75933
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLImageDataWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601289E RID: 75934 RVA: 0x001A00C4 File Offset: 0x0019E2C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLImageDataWriter.vtkXMLImageDataWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601289F RID: 75935
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLImageDataWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128A0 RID: 75936 RVA: 0x001A00E4 File Offset: 0x0019E2E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLImageDataWriter.vtkXMLImageDataWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060128A1 RID: 75937
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLImageDataWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128A2 RID: 75938 RVA: 0x001A0100 File Offset: 0x0019E300
		public override int IsA(string type)
		{
			return vtkXMLImageDataWriter.vtkXMLImageDataWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060128A3 RID: 75939
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLImageDataWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128A4 RID: 75940 RVA: 0x001A0120 File Offset: 0x0019E320
		public new static int IsTypeOf(string type)
		{
			return vtkXMLImageDataWriter.vtkXMLImageDataWriter_IsTypeOf_06(type);
		}

		// Token: 0x060128A5 RID: 75941
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128A6 RID: 75942 RVA: 0x001A013C File Offset: 0x0019E33C
		public new vtkXMLImageDataWriter NewInstance()
		{
			vtkXMLImageDataWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataWriter.vtkXMLImageDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLImageDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060128A7 RID: 75943
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLImageDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060128A8 RID: 75944 RVA: 0x001A0198 File Offset: 0x0019E398
		public new static vtkXMLImageDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLImageDataWriter vtkXMLImageDataWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLImageDataWriter.vtkXMLImageDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLImageDataWriter = (vtkXMLImageDataWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLImageDataWriter.Register(null);
				}
			}
			return vtkXMLImageDataWriter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001555 RID: 5461
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLImageDataWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001556 RID: 5462
		public new static readonly string MRClassNameKey = "class vtkXMLImageDataWriter";
	}
}
