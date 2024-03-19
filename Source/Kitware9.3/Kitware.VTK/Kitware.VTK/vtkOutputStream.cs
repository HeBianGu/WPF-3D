using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOutputStream
	/// </summary>
	/// <remarks>
	///    Wraps a binary output stream with a VTK interface.
	///
	/// vtkOutputStream provides a VTK-style interface wrapping around a
	/// standard output stream.  The access methods are virtual so that
	/// subclasses can transparently provide encoding of the output.  Data
	/// lengths for Write calls refer to the length of the data in memory.
	/// The actual length in the stream may differ for subclasses that
	/// implement an encoding scheme.
	/// </remarks>
	// Token: 0x02000724 RID: 1828
	public class vtkOutputStream : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060131DC RID: 78300 RVA: 0x001B04D3 File Offset: 0x001AE6D3
		static vtkOutputStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutputStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060131DD RID: 78301 RVA: 0x001B04FB File Offset: 0x001AE6FB
		public vtkOutputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060131DE RID: 78302
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131DF RID: 78303 RVA: 0x001B050C File Offset: 0x001AE70C
		public new static vtkOutputStream New()
		{
			vtkOutputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputStream.vtkOutputStream_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131E0 RID: 78304 RVA: 0x001B0560 File Offset: 0x001AE760
		public vtkOutputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOutputStream.vtkOutputStream_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060131E1 RID: 78305 RVA: 0x001B05A4 File Offset: 0x001AE7A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060131E2 RID: 78306
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputStream_EndWriting_01(HandleRef pThis);

		/// <summary>
		/// Called after all desired calls to Write have been made.  After
		/// this call, the caller is free to change the position of the
		/// stream.  Additional writes should not be done until after another
		/// call to StartWriting.
		/// </summary>
		// Token: 0x060131E3 RID: 78307 RVA: 0x001B05B0 File Offset: 0x001AE7B0
		public virtual int EndWriting()
		{
			return vtkOutputStream.vtkOutputStream_EndWriting_01(base.GetCppThis());
		}

		// Token: 0x060131E4 RID: 78308
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutputStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131E5 RID: 78309 RVA: 0x001B05D0 File Offset: 0x001AE7D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOutputStream.vtkOutputStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060131E6 RID: 78310
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOutputStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131E7 RID: 78311 RVA: 0x001B05F0 File Offset: 0x001AE7F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOutputStream.vtkOutputStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060131E8 RID: 78312
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131E9 RID: 78313 RVA: 0x001B060C File Offset: 0x001AE80C
		public override int IsA(string type)
		{
			return vtkOutputStream.vtkOutputStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060131EA RID: 78314
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131EB RID: 78315 RVA: 0x001B062C File Offset: 0x001AE82C
		public new static int IsTypeOf(string type)
		{
			return vtkOutputStream.vtkOutputStream_IsTypeOf_05(type);
		}

		// Token: 0x060131EC RID: 78316
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131ED RID: 78317 RVA: 0x001B0648 File Offset: 0x001AE848
		public new vtkOutputStream NewInstance()
		{
			vtkOutputStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputStream.vtkOutputStream_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060131EE RID: 78318
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOutputStream_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131EF RID: 78319 RVA: 0x001B06A4 File Offset: 0x001AE8A4
		public new static vtkOutputStream SafeDownCast(vtkObjectBase o)
		{
			vtkOutputStream vtkOutputStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOutputStream.vtkOutputStream_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutputStream = (vtkOutputStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutputStream.Register(null);
				}
			}
			return vtkOutputStream;
		}

		// Token: 0x060131F0 RID: 78320
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputStream_StartWriting_09(HandleRef pThis);

		/// <summary>
		/// Called after the stream position has been set by the caller, but
		/// before any Write calls.  The stream position should not be
		/// adjusted by the caller until after an EndWriting call.
		/// </summary>
		// Token: 0x060131F1 RID: 78321 RVA: 0x001B0724 File Offset: 0x001AE924
		public virtual int StartWriting()
		{
			return vtkOutputStream.vtkOutputStream_StartWriting_09(base.GetCppThis());
		}

		// Token: 0x060131F2 RID: 78322
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOutputStream_Write_10(HandleRef pThis, IntPtr data, ulong length);

		/// <summary>
		/// Write output data of the given length.
		/// </summary>
		// Token: 0x060131F3 RID: 78323 RVA: 0x001B0744 File Offset: 0x001AE944
		public virtual int Write(IntPtr data, ulong length)
		{
			return vtkOutputStream.vtkOutputStream_Write_10(base.GetCppThis(), data, length);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001614 RID: 5652
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutputStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001615 RID: 5653
		public new static readonly string MRClassNameKey = "class vtkOutputStream";
	}
}
