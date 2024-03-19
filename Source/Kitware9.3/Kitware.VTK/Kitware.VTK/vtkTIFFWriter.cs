using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTIFFWriter
	/// </summary>
	/// <remarks>
	///    write out image data as a TIFF file
	///
	/// vtkTIFFWriter writes image data as a TIFF data file. Data can be written
	/// uncompressed or compressed. Several forms of compression are supported
	/// including packed bits, JPEG, deflation, and LZW. (Note: LZW compression
	/// is currently under patent in the US and is disabled until the patent
	/// expires. However, the mechanism for supporting this compression is available
	/// for those with a valid license or to whom the patent does not apply.)
	/// </remarks>
	// Token: 0x020007A4 RID: 1956
	public class vtkTIFFWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014110 RID: 82192 RVA: 0x001C5B83 File Offset: 0x001C3D83
		static vtkTIFFWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTIFFWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTIFFWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014111 RID: 82193 RVA: 0x001C5BAB File Offset: 0x001C3DAB
		public vtkTIFFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014112 RID: 82194
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014113 RID: 82195 RVA: 0x001C5BBC File Offset: 0x001C3DBC
		public new static vtkTIFFWriter New()
		{
			vtkTIFFWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTIFFWriter.vtkTIFFWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014114 RID: 82196 RVA: 0x001C5C10 File Offset: 0x001C3E10
		public vtkTIFFWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTIFFWriter.vtkTIFFWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014115 RID: 82197 RVA: 0x001C5C54 File Offset: 0x001C3E54
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014116 RID: 82198
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFWriter_GetCompression_01(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x06014117 RID: 82199 RVA: 0x001C5C60 File Offset: 0x001C3E60
		public virtual int GetCompression()
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetCompression_01(base.GetCppThis());
		}

		// Token: 0x06014118 RID: 82200
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFWriter_GetCompressionMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x06014119 RID: 82201 RVA: 0x001C5C80 File Offset: 0x001C3E80
		public virtual int GetCompressionMaxValue()
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetCompressionMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0601411A RID: 82202
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFWriter_GetCompressionMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x0601411B RID: 82203 RVA: 0x001C5CA0 File Offset: 0x001C3EA0
		public virtual int GetCompressionMinValue()
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetCompressionMinValue_03(base.GetCppThis());
		}

		// Token: 0x0601411C RID: 82204
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTIFFWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601411D RID: 82205 RVA: 0x001C5CC0 File Offset: 0x001C3EC0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601411E RID: 82206
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTIFFWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601411F RID: 82207 RVA: 0x001C5CE0 File Offset: 0x001C3EE0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014120 RID: 82208
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014121 RID: 82209 RVA: 0x001C5CFC File Offset: 0x001C3EFC
		public override int IsA(string type)
		{
			return vtkTIFFWriter.vtkTIFFWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014122 RID: 82210
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTIFFWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014123 RID: 82211 RVA: 0x001C5D1C File Offset: 0x001C3F1C
		public new static int IsTypeOf(string type)
		{
			return vtkTIFFWriter.vtkTIFFWriter_IsTypeOf_07(type);
		}

		// Token: 0x06014124 RID: 82212
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014125 RID: 82213 RVA: 0x001C5D38 File Offset: 0x001C3F38
		public new vtkTIFFWriter NewInstance()
		{
			vtkTIFFWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTIFFWriter.vtkTIFFWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014126 RID: 82214
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTIFFWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014127 RID: 82215 RVA: 0x001C5D94 File Offset: 0x001C3F94
		public new static vtkTIFFWriter SafeDownCast(vtkObjectBase o)
		{
			vtkTIFFWriter vtkTIFFWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTIFFWriter.vtkTIFFWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTIFFWriter = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTIFFWriter.Register(null);
				}
			}
			return vtkTIFFWriter;
		}

		// Token: 0x06014128 RID: 82216
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_SetCompression_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x06014129 RID: 82217 RVA: 0x001C5E13 File Offset: 0x001C4013
		public virtual void SetCompression(int _arg)
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompression_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601412A RID: 82218
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_SetCompressionToDeflate_12(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x0601412B RID: 82219 RVA: 0x001C5E23 File Offset: 0x001C4023
		public void SetCompressionToDeflate()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToDeflate_12(base.GetCppThis());
		}

		// Token: 0x0601412C RID: 82220
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_SetCompressionToJPEG_13(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x0601412D RID: 82221 RVA: 0x001C5E32 File Offset: 0x001C4032
		public void SetCompressionToJPEG()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToJPEG_13(base.GetCppThis());
		}

		// Token: 0x0601412E RID: 82222
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_SetCompressionToLZW_14(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x0601412F RID: 82223 RVA: 0x001C5E41 File Offset: 0x001C4041
		public void SetCompressionToLZW()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToLZW_14(base.GetCppThis());
		}

		// Token: 0x06014130 RID: 82224
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_SetCompressionToNoCompression_15(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x06014131 RID: 82225 RVA: 0x001C5E50 File Offset: 0x001C4050
		public void SetCompressionToNoCompression()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToNoCompression_15(base.GetCppThis());
		}

		// Token: 0x06014132 RID: 82226
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_SetCompressionToPackBits_16(HandleRef pThis);

		/// <summary>
		/// Set compression type. Sinze LZW compression is patented outside US, the
		/// additional work steps have to be taken in order to use that compression.
		/// </summary>
		// Token: 0x06014133 RID: 82227 RVA: 0x001C5E5F File Offset: 0x001C405F
		public void SetCompressionToPackBits()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToPackBits_16(base.GetCppThis());
		}

		// Token: 0x06014134 RID: 82228
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTIFFWriter_Write_17(HandleRef pThis);

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x06014135 RID: 82229 RVA: 0x001C5E6E File Offset: 0x001C406E
		public override void Write()
		{
			vtkTIFFWriter.vtkTIFFWriter_Write_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001748 RID: 5960
		public new const string MRFullTypeName = "Kitware.VTK.vtkTIFFWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001749 RID: 5961
		public new static readonly string MRClassNameKey = "class vtkTIFFWriter";

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x020007A5 RID: 1957
		public enum Deflate_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400174B RID: 5963
			Deflate = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400174C RID: 5964
			JPEG = 2,
			/// <summary>enum member</summary>
			// Token: 0x0400174D RID: 5965
			LZW = 4,
			/// <summary>enum member</summary>
			// Token: 0x0400174E RID: 5966
			NoCompression = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400174F RID: 5967
			PackBits
		}
	}
}
