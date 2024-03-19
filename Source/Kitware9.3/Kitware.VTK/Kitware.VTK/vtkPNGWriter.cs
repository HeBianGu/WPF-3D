using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPNGWriter
	/// </summary>
	/// <remarks>
	///    Writes PNG files.
	///
	/// vtkPNGWriter writes PNG files. It supports 1 to 4 component data of
	/// unsigned char or unsigned short
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPNGReader
	/// </seealso>
	// Token: 0x0200079D RID: 1949
	public class vtkPNGWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601403A RID: 81978 RVA: 0x001C45EF File Offset: 0x001C27EF
		static vtkPNGWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPNGWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNGWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601403B RID: 81979 RVA: 0x001C4617 File Offset: 0x001C2817
		public vtkPNGWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601403C RID: 81980
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601403D RID: 81981 RVA: 0x001C4628 File Offset: 0x001C2828
		public new static vtkPNGWriter New()
		{
			vtkPNGWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601403E RID: 81982 RVA: 0x001C467C File Offset: 0x001C287C
		public vtkPNGWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPNGWriter.vtkPNGWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601403F RID: 81983 RVA: 0x001C46C0 File Offset: 0x001C28C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014040 RID: 81984
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_AddText_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string key, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Adds a text chunk to the PNG. More than one text chunk with the same key is permissible.
		/// There are a number of predefined keywords that should be used
		/// when appropriate. See
		/// http://www.libpng.org/pub/png/spec/1.2/PNG-Chunks.html
		/// for more information.
		/// </summary>
		// Token: 0x06014041 RID: 81985 RVA: 0x001C46CB File Offset: 0x001C28CB
		public void AddText(string key, string value)
		{
			vtkPNGWriter.vtkPNGWriter_AddText_01(base.GetCppThis(), key, value);
		}

		// Token: 0x06014042 RID: 81986
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_ClearText_02(HandleRef pThis);

		/// <summary>
		/// Clear out any key/value pairs added through the AddText() member function.
		/// </summary>
		// Token: 0x06014043 RID: 81987 RVA: 0x001C46DC File Offset: 0x001C28DC
		public void ClearText()
		{
			vtkPNGWriter.vtkPNGWriter_ClearText_02(base.GetCppThis());
		}

		// Token: 0x06014044 RID: 81988
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGWriter_GetCompressionLevel_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the zlib compression level.
		/// The range is 0-9, with 0 meaning no compression
		/// corresponding to the largest file size, and 9 meaning
		/// best compression, corresponding to the smallest file size.
		/// The default is 5.
		/// </summary>
		// Token: 0x06014045 RID: 81989 RVA: 0x001C46EC File Offset: 0x001C28EC
		public virtual int GetCompressionLevel()
		{
			return vtkPNGWriter.vtkPNGWriter_GetCompressionLevel_03(base.GetCppThis());
		}

		// Token: 0x06014046 RID: 81990
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGWriter_GetCompressionLevelMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the zlib compression level.
		/// The range is 0-9, with 0 meaning no compression
		/// corresponding to the largest file size, and 9 meaning
		/// best compression, corresponding to the smallest file size.
		/// The default is 5.
		/// </summary>
		// Token: 0x06014047 RID: 81991 RVA: 0x001C470C File Offset: 0x001C290C
		public virtual int GetCompressionLevelMaxValue()
		{
			return vtkPNGWriter.vtkPNGWriter_GetCompressionLevelMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06014048 RID: 81992
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGWriter_GetCompressionLevelMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the zlib compression level.
		/// The range is 0-9, with 0 meaning no compression
		/// corresponding to the largest file size, and 9 meaning
		/// best compression, corresponding to the smallest file size.
		/// The default is 5.
		/// </summary>
		// Token: 0x06014049 RID: 81993 RVA: 0x001C472C File Offset: 0x001C292C
		public virtual int GetCompressionLevelMinValue()
		{
			return vtkPNGWriter.vtkPNGWriter_GetCompressionLevelMinValue_05(base.GetCppThis());
		}

		// Token: 0x0601404A RID: 81994
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNGWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601404B RID: 81995 RVA: 0x001C474C File Offset: 0x001C294C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPNGWriter.vtkPNGWriter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601404C RID: 81996
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPNGWriter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601404D RID: 81997 RVA: 0x001C476C File Offset: 0x001C296C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPNGWriter.vtkPNGWriter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601404E RID: 81998
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGWriter_GetResult_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When writing to memory this is the result, it will be nullptr until the
		/// data is written the first time
		/// </summary>
		// Token: 0x0601404F RID: 81999 RVA: 0x001C4788 File Offset: 0x001C2988
		public virtual vtkUnsignedCharArray GetResult()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_GetResult_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014050 RID: 82000
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkPNGWriter_GetWriteToMemory_09(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06014051 RID: 82001 RVA: 0x001C47F8 File Offset: 0x001C29F8
		public virtual uint GetWriteToMemory()
		{
			return vtkPNGWriter.vtkPNGWriter_GetWriteToMemory_09(base.GetCppThis());
		}

		// Token: 0x06014052 RID: 82002
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGWriter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014053 RID: 82003 RVA: 0x001C4818 File Offset: 0x001C2A18
		public override int IsA(string type)
		{
			return vtkPNGWriter.vtkPNGWriter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06014054 RID: 82004
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPNGWriter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014055 RID: 82005 RVA: 0x001C4838 File Offset: 0x001C2A38
		public new static int IsTypeOf(string type)
		{
			return vtkPNGWriter.vtkPNGWriter_IsTypeOf_11(type);
		}

		// Token: 0x06014056 RID: 82006
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014057 RID: 82007 RVA: 0x001C4854 File Offset: 0x001C2A54
		public new vtkPNGWriter NewInstance()
		{
			vtkPNGWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014058 RID: 82008
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPNGWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014059 RID: 82009 RVA: 0x001C48B0 File Offset: 0x001C2AB0
		public new static vtkPNGWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPNGWriter vtkPNGWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPNGWriter = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPNGWriter.Register(null);
				}
			}
			return vtkPNGWriter;
		}

		// Token: 0x0601405A RID: 82010
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_SetCompressionLevel_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the zlib compression level.
		/// The range is 0-9, with 0 meaning no compression
		/// corresponding to the largest file size, and 9 meaning
		/// best compression, corresponding to the smallest file size.
		/// The default is 5.
		/// </summary>
		// Token: 0x0601405B RID: 82011 RVA: 0x001C492F File Offset: 0x001C2B2F
		public virtual void SetCompressionLevel(int _arg)
		{
			vtkPNGWriter.vtkPNGWriter_SetCompressionLevel_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601405C RID: 82012
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_SetResult_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When writing to memory this is the result, it will be nullptr until the
		/// data is written the first time
		/// </summary>
		// Token: 0x0601405D RID: 82013 RVA: 0x001C4940 File Offset: 0x001C2B40
		public virtual void SetResult(vtkUnsignedCharArray arg0)
		{
			vtkPNGWriter.vtkPNGWriter_SetResult_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601405E RID: 82014
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_SetWriteToMemory_17(HandleRef pThis, uint _arg);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x0601405F RID: 82015 RVA: 0x001C496F File Offset: 0x001C2B6F
		public virtual void SetWriteToMemory(uint _arg)
		{
			vtkPNGWriter.vtkPNGWriter_SetWriteToMemory_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06014060 RID: 82016
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_Write_18(HandleRef pThis);

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x06014061 RID: 82017 RVA: 0x001C497F File Offset: 0x001C2B7F
		public override void Write()
		{
			vtkPNGWriter.vtkPNGWriter_Write_18(base.GetCppThis());
		}

		// Token: 0x06014062 RID: 82018
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_WriteToMemoryOff_19(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06014063 RID: 82019 RVA: 0x001C498E File Offset: 0x001C2B8E
		public virtual void WriteToMemoryOff()
		{
			vtkPNGWriter.vtkPNGWriter_WriteToMemoryOff_19(base.GetCppThis());
		}

		// Token: 0x06014064 RID: 82020
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPNGWriter_WriteToMemoryOn_20(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06014065 RID: 82021 RVA: 0x001C499D File Offset: 0x001C2B9D
		public virtual void WriteToMemoryOn()
		{
			vtkPNGWriter.vtkPNGWriter_WriteToMemoryOn_20(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400173A RID: 5946
		public new const string MRFullTypeName = "Kitware.VTK.vtkPNGWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400173B RID: 5947
		public new static readonly string MRClassNameKey = "class vtkPNGWriter";
	}
}
