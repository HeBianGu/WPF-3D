using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  vtkResourceStream implementation for file input
	/// </remarks>
	// Token: 0x0200072B RID: 1835
	public class vtkFileResourceStream : vtkResourceStream
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601328E RID: 78478 RVA: 0x001B1623 File Offset: 0x001AF823
		static vtkFileResourceStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFileResourceStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFileResourceStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601328F RID: 78479 RVA: 0x001B164B File Offset: 0x001AF84B
		public vtkFileResourceStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013290 RID: 78480
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileResourceStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013291 RID: 78481 RVA: 0x001B165C File Offset: 0x001AF85C
		public new static vtkFileResourceStream New()
		{
			vtkFileResourceStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFileResourceStream.vtkFileResourceStream_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFileResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013292 RID: 78482 RVA: 0x001B16B0 File Offset: 0x001AF8B0
		public vtkFileResourceStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFileResourceStream.vtkFileResourceStream_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013293 RID: 78483 RVA: 0x001B16F4 File Offset: 0x001AF8F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013294 RID: 78484
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFileResourceStream_EndOfStream_01(HandleRef pThis);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x06013295 RID: 78485 RVA: 0x001B1700 File Offset: 0x001AF900
		public override bool EndOfStream()
		{
			return vtkFileResourceStream.vtkFileResourceStream_EndOfStream_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06013296 RID: 78486
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFileResourceStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013297 RID: 78487 RVA: 0x001B1728 File Offset: 0x001AF928
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFileResourceStream.vtkFileResourceStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013298 RID: 78488
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFileResourceStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013299 RID: 78489 RVA: 0x001B1748 File Offset: 0x001AF948
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFileResourceStream.vtkFileResourceStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601329A RID: 78490
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFileResourceStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601329B RID: 78491 RVA: 0x001B1764 File Offset: 0x001AF964
		public override int IsA(string type)
		{
			return vtkFileResourceStream.vtkFileResourceStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601329C RID: 78492
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFileResourceStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601329D RID: 78493 RVA: 0x001B1784 File Offset: 0x001AF984
		public new static int IsTypeOf(string type)
		{
			return vtkFileResourceStream.vtkFileResourceStream_IsTypeOf_05(type);
		}

		// Token: 0x0601329E RID: 78494
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileResourceStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601329F RID: 78495 RVA: 0x001B17A0 File Offset: 0x001AF9A0
		public new vtkFileResourceStream NewInstance()
		{
			vtkFileResourceStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFileResourceStream.vtkFileResourceStream_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFileResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060132A0 RID: 78496
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFileResourceStream_Open_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string path);

		/// <summary>
		/// @brief Open a file
		///
		/// Opening a file reset the stream to initial position: Tell() = 0.
		/// EndOfStream is set to true if file opening failed.
		/// If path is nullptr, the file will only be closed.
		/// This function will increase modified time.
		///
		/// @param path the file path
		/// @return true if file was succefully opened, false otherwise.
		/// Return false if path is nullptr.
		/// </summary>
		// Token: 0x060132A1 RID: 78497 RVA: 0x001B17FC File Offset: 0x001AF9FC
		public bool Open(string path)
		{
			return vtkFileResourceStream.vtkFileResourceStream_Open_08(base.GetCppThis(), path) != 0;
		}

		// Token: 0x060132A2 RID: 78498
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFileResourceStream_Read_09(HandleRef pThis, IntPtr buffer, ulong bytes);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x060132A3 RID: 78499 RVA: 0x001B1824 File Offset: 0x001AFA24
		public override ulong Read(IntPtr buffer, ulong bytes)
		{
			return vtkFileResourceStream.vtkFileResourceStream_Read_09(base.GetCppThis(), buffer, bytes);
		}

		// Token: 0x060132A4 RID: 78500
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFileResourceStream_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132A5 RID: 78501 RVA: 0x001B1848 File Offset: 0x001AFA48
		public new static vtkFileResourceStream SafeDownCast(vtkObjectBase o)
		{
			vtkFileResourceStream vtkFileResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFileResourceStream.vtkFileResourceStream_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFileResourceStream = (vtkFileResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFileResourceStream.Register(null);
				}
			}
			return vtkFileResourceStream;
		}

		// Token: 0x060132A6 RID: 78502
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFileResourceStream_Seek_11(HandleRef pThis, long pos, vtkResourceStream.SeekDirection dir);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x060132A7 RID: 78503 RVA: 0x001B18C8 File Offset: 0x001AFAC8
		public override long Seek(long pos, vtkResourceStream.SeekDirection dir)
		{
			return vtkFileResourceStream.vtkFileResourceStream_Seek_11(base.GetCppThis(), pos, dir);
		}

		// Token: 0x060132A8 RID: 78504
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFileResourceStream_Tell_12(HandleRef pThis);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x060132A9 RID: 78505 RVA: 0x001B18EC File Offset: 0x001AFAEC
		public override long Tell()
		{
			return vtkFileResourceStream.vtkFileResourceStream_Tell_12(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001624 RID: 5668
		public new const string MRFullTypeName = "Kitware.VTK.vtkFileResourceStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001625 RID: 5669
		public new static readonly string MRClassNameKey = "class vtkFileResourceStream";
	}
}
