using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJPEGWriter
	/// </summary>
	/// <remarks>
	///    Writes JPEG files.
	///
	/// vtkJPEGWriter writes JPEG files. It supports 1 and 3 component data of
	/// unsigned char. It relies on the IJG's libjpeg.  Thanks to IJG for
	/// supplying a public jpeg IO library.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkJPEGReader
	/// </seealso>
	// Token: 0x02000789 RID: 1929
	public class vtkJPEGWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013CD2 RID: 81106 RVA: 0x001BFD7B File Offset: 0x001BDF7B
		static vtkJPEGWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJPEGWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJPEGWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013CD3 RID: 81107 RVA: 0x001BFDA3 File Offset: 0x001BDFA3
		public vtkJPEGWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013CD4 RID: 81108
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CD5 RID: 81109 RVA: 0x001BFDB4 File Offset: 0x001BDFB4
		public new static vtkJPEGWriter New()
		{
			vtkJPEGWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CD6 RID: 81110 RVA: 0x001BFE08 File Offset: 0x001BE008
		public vtkJPEGWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJPEGWriter.vtkJPEGWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013CD7 RID: 81111 RVA: 0x001BFE4C File Offset: 0x001BE04C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013CD8 RID: 81112
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJPEGWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CD9 RID: 81113 RVA: 0x001BFE58 File Offset: 0x001BE058
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013CDA RID: 81114
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJPEGWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CDB RID: 81115 RVA: 0x001BFE78 File Offset: 0x001BE078
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013CDC RID: 81116
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkJPEGWriter_GetProgressive_03(HandleRef pThis);

		/// <summary>
		/// Progressive JPEG generation.
		/// </summary>
		// Token: 0x06013CDD RID: 81117 RVA: 0x001BFE94 File Offset: 0x001BE094
		public virtual uint GetProgressive()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetProgressive_03(base.GetCppThis());
		}

		// Token: 0x06013CDE RID: 81118
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGWriter_GetQuality_04(HandleRef pThis);

		/// <summary>
		/// Compression quality. 0 = Low quality, 100 = High quality
		/// </summary>
		// Token: 0x06013CDF RID: 81119 RVA: 0x001BFEB4 File Offset: 0x001BE0B4
		public virtual int GetQuality()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetQuality_04(base.GetCppThis());
		}

		// Token: 0x06013CE0 RID: 81120
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGWriter_GetQualityMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Compression quality. 0 = Low quality, 100 = High quality
		/// </summary>
		// Token: 0x06013CE1 RID: 81121 RVA: 0x001BFED4 File Offset: 0x001BE0D4
		public virtual int GetQualityMaxValue()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetQualityMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06013CE2 RID: 81122
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGWriter_GetQualityMinValue_06(HandleRef pThis);

		/// <summary>
		/// Compression quality. 0 = Low quality, 100 = High quality
		/// </summary>
		// Token: 0x06013CE3 RID: 81123 RVA: 0x001BFEF4 File Offset: 0x001BE0F4
		public virtual int GetQualityMinValue()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetQualityMinValue_06(base.GetCppThis());
		}

		// Token: 0x06013CE4 RID: 81124
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGWriter_GetResult_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When writing to memory this is the result, it will be nullptr until the
		/// data is written the first time
		/// </summary>
		// Token: 0x06013CE5 RID: 81125 RVA: 0x001BFF14 File Offset: 0x001BE114
		public virtual vtkUnsignedCharArray GetResult()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_GetResult_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x06013CE6 RID: 81126
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkJPEGWriter_GetWriteToMemory_08(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06013CE7 RID: 81127 RVA: 0x001BFF84 File Offset: 0x001BE184
		public virtual uint GetWriteToMemory()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetWriteToMemory_08(base.GetCppThis());
		}

		// Token: 0x06013CE8 RID: 81128
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGWriter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CE9 RID: 81129 RVA: 0x001BFFA4 File Offset: 0x001BE1A4
		public override int IsA(string type)
		{
			return vtkJPEGWriter.vtkJPEGWriter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06013CEA RID: 81130
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJPEGWriter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CEB RID: 81131 RVA: 0x001BFFC4 File Offset: 0x001BE1C4
		public new static int IsTypeOf(string type)
		{
			return vtkJPEGWriter.vtkJPEGWriter_IsTypeOf_10(type);
		}

		// Token: 0x06013CEC RID: 81132
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CED RID: 81133 RVA: 0x001BFFE0 File Offset: 0x001BE1E0
		public new vtkJPEGWriter NewInstance()
		{
			vtkJPEGWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013CEE RID: 81134
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_ProgressiveOff_13(HandleRef pThis);

		/// <summary>
		/// Progressive JPEG generation.
		/// </summary>
		// Token: 0x06013CEF RID: 81135 RVA: 0x001C003A File Offset: 0x001BE23A
		public virtual void ProgressiveOff()
		{
			vtkJPEGWriter.vtkJPEGWriter_ProgressiveOff_13(base.GetCppThis());
		}

		// Token: 0x06013CF0 RID: 81136
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_ProgressiveOn_14(HandleRef pThis);

		/// <summary>
		/// Progressive JPEG generation.
		/// </summary>
		// Token: 0x06013CF1 RID: 81137 RVA: 0x001C0049 File Offset: 0x001BE249
		public virtual void ProgressiveOn()
		{
			vtkJPEGWriter.vtkJPEGWriter_ProgressiveOn_14(base.GetCppThis());
		}

		// Token: 0x06013CF2 RID: 81138
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJPEGWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CF3 RID: 81139 RVA: 0x001C0058 File Offset: 0x001BE258
		public new static vtkJPEGWriter SafeDownCast(vtkObjectBase o)
		{
			vtkJPEGWriter vtkJPEGWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJPEGWriter = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJPEGWriter.Register(null);
				}
			}
			return vtkJPEGWriter;
		}

		// Token: 0x06013CF4 RID: 81140
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_SetProgressive_16(HandleRef pThis, uint _arg);

		/// <summary>
		/// Progressive JPEG generation.
		/// </summary>
		// Token: 0x06013CF5 RID: 81141 RVA: 0x001C00D7 File Offset: 0x001BE2D7
		public virtual void SetProgressive(uint _arg)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetProgressive_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06013CF6 RID: 81142
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_SetQuality_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Compression quality. 0 = Low quality, 100 = High quality
		/// </summary>
		// Token: 0x06013CF7 RID: 81143 RVA: 0x001C00E7 File Offset: 0x001BE2E7
		public virtual void SetQuality(int _arg)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetQuality_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06013CF8 RID: 81144
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_SetResult_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When writing to memory this is the result, it will be nullptr until the
		/// data is written the first time
		/// </summary>
		// Token: 0x06013CF9 RID: 81145 RVA: 0x001C00F8 File Offset: 0x001BE2F8
		public virtual void SetResult(vtkUnsignedCharArray arg0)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetResult_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013CFA RID: 81146
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_SetWriteToMemory_19(HandleRef pThis, uint _arg);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06013CFB RID: 81147 RVA: 0x001C0127 File Offset: 0x001BE327
		public virtual void SetWriteToMemory(uint _arg)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetWriteToMemory_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06013CFC RID: 81148
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_Write_20(HandleRef pThis);

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x06013CFD RID: 81149 RVA: 0x001C0137 File Offset: 0x001BE337
		public override void Write()
		{
			vtkJPEGWriter.vtkJPEGWriter_Write_20(base.GetCppThis());
		}

		// Token: 0x06013CFE RID: 81150
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_WriteToMemoryOff_21(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06013CFF RID: 81151 RVA: 0x001C0146 File Offset: 0x001BE346
		public virtual void WriteToMemoryOff()
		{
			vtkJPEGWriter.vtkJPEGWriter_WriteToMemoryOff_21(base.GetCppThis());
		}

		// Token: 0x06013D00 RID: 81152
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJPEGWriter_WriteToMemoryOn_22(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06013D01 RID: 81153 RVA: 0x001C0155 File Offset: 0x001BE355
		public virtual void WriteToMemoryOn()
		{
			vtkJPEGWriter.vtkJPEGWriter_WriteToMemoryOn_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C4 RID: 5828
		public new const string MRFullTypeName = "Kitware.VTK.vtkJPEGWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C5 RID: 5829
		public new static readonly string MRClassNameKey = "class vtkJPEGWriter";
	}
}
