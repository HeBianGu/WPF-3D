using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBMPWriter
	/// </summary>
	/// <remarks>
	///    Writes Windows BMP files.
	///
	/// vtkBMPWriter writes BMP files. The data type
	/// of the file is unsigned char regardless of the input type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBMPReader
	/// </seealso>
	// Token: 0x0200075D RID: 1885
	public class vtkBMPWriter : vtkImageWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601393F RID: 80191 RVA: 0x001BAA8B File Offset: 0x001B8C8B
		static vtkBMPWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBMPWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBMPWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013940 RID: 80192 RVA: 0x001BAAB3 File Offset: 0x001B8CB3
		public vtkBMPWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013941 RID: 80193
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013942 RID: 80194 RVA: 0x001BAAC4 File Offset: 0x001B8CC4
		public new static vtkBMPWriter New()
		{
			vtkBMPWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPWriter.vtkBMPWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBMPWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013943 RID: 80195 RVA: 0x001BAB18 File Offset: 0x001B8D18
		public vtkBMPWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBMPWriter.vtkBMPWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013944 RID: 80196 RVA: 0x001BAB5C File Offset: 0x001B8D5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013945 RID: 80197
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBMPWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013946 RID: 80198 RVA: 0x001BAB68 File Offset: 0x001B8D68
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBMPWriter.vtkBMPWriter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013947 RID: 80199
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBMPWriter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013948 RID: 80200 RVA: 0x001BAB88 File Offset: 0x001B8D88
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBMPWriter.vtkBMPWriter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06013949 RID: 80201
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPWriter_GetResult_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// When writing to memory this is the result, it will be NULL until the
		/// data is written the first time
		/// </summary>
		// Token: 0x0601394A RID: 80202 RVA: 0x001BABA4 File Offset: 0x001B8DA4
		public virtual vtkUnsignedCharArray GetResult()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPWriter.vtkBMPWriter_GetResult_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601394B RID: 80203
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkBMPWriter_GetWriteToMemory_04(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x0601394C RID: 80204 RVA: 0x001BAC14 File Offset: 0x001B8E14
		public virtual uint GetWriteToMemory()
		{
			return vtkBMPWriter.vtkBMPWriter_GetWriteToMemory_04(base.GetCppThis());
		}

		// Token: 0x0601394D RID: 80205
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601394E RID: 80206 RVA: 0x001BAC34 File Offset: 0x001B8E34
		public override int IsA(string type)
		{
			return vtkBMPWriter.vtkBMPWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601394F RID: 80207
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBMPWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013950 RID: 80208 RVA: 0x001BAC54 File Offset: 0x001B8E54
		public new static int IsTypeOf(string type)
		{
			return vtkBMPWriter.vtkBMPWriter_IsTypeOf_06(type);
		}

		// Token: 0x06013951 RID: 80209
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013952 RID: 80210 RVA: 0x001BAC70 File Offset: 0x001B8E70
		public new vtkBMPWriter NewInstance()
		{
			vtkBMPWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPWriter.vtkBMPWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBMPWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013953 RID: 80211
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBMPWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013954 RID: 80212 RVA: 0x001BACCC File Offset: 0x001B8ECC
		public new static vtkBMPWriter SafeDownCast(vtkObjectBase o)
		{
			vtkBMPWriter vtkBMPWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBMPWriter.vtkBMPWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBMPWriter = (vtkBMPWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBMPWriter.Register(null);
				}
			}
			return vtkBMPWriter;
		}

		// Token: 0x06013955 RID: 80213
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPWriter_SetResult_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// When writing to memory this is the result, it will be NULL until the
		/// data is written the first time
		/// </summary>
		// Token: 0x06013956 RID: 80214 RVA: 0x001BAD4C File Offset: 0x001B8F4C
		public virtual void SetResult(vtkUnsignedCharArray arg0)
		{
			vtkBMPWriter.vtkBMPWriter_SetResult_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013957 RID: 80215
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPWriter_SetWriteToMemory_11(HandleRef pThis, uint _arg);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x06013958 RID: 80216 RVA: 0x001BAD7B File Offset: 0x001B8F7B
		public virtual void SetWriteToMemory(uint _arg)
		{
			vtkBMPWriter.vtkBMPWriter_SetWriteToMemory_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06013959 RID: 80217
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPWriter_WriteToMemoryOff_12(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x0601395A RID: 80218 RVA: 0x001BAD8B File Offset: 0x001B8F8B
		public virtual void WriteToMemoryOff()
		{
			vtkBMPWriter.vtkBMPWriter_WriteToMemoryOff_12(base.GetCppThis());
		}

		// Token: 0x0601395B RID: 80219
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBMPWriter_WriteToMemoryOn_13(HandleRef pThis);

		/// <summary>
		/// Write the image to memory (a vtkUnsignedCharArray)
		/// </summary>
		// Token: 0x0601395C RID: 80220 RVA: 0x001BAD9A File Offset: 0x001B8F9A
		public virtual void WriteToMemoryOn()
		{
			vtkBMPWriter.vtkBMPWriter_WriteToMemoryOn_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001697 RID: 5783
		public new const string MRFullTypeName = "Kitware.VTK.vtkBMPWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001698 RID: 5784
		public new static readonly string MRClassNameKey = "class vtkBMPWriter";
	}
}
