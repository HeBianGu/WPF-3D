using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000B38 RID: 2872
	public class vtkTypeUInt64Array : vtkUnsignedLongLongArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E124 RID: 123172 RVA: 0x002A8483 File Offset: 0x002A6683
		static vtkTypeUInt64Array()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeUInt64Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeUInt64Array"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E125 RID: 123173 RVA: 0x002A84AB File Offset: 0x002A66AB
		public vtkTypeUInt64Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E126 RID: 123174
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt64Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E127 RID: 123175 RVA: 0x002A84BC File Offset: 0x002A66BC
		public new static vtkTypeUInt64Array New()
		{
			vtkTypeUInt64Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt64Array.vtkTypeUInt64Array_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E128 RID: 123176 RVA: 0x002A8510 File Offset: 0x002A6710
		public vtkTypeUInt64Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTypeUInt64Array.vtkTypeUInt64Array_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E129 RID: 123177 RVA: 0x002A8554 File Offset: 0x002A6754
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E12A RID: 123178
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt64Array_FastDownCast_01(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E12B RID: 123179 RVA: 0x002A8560 File Offset: 0x002A6760
		public new static vtkTypeUInt64Array FastDownCast(vtkAbstractArray source)
		{
			vtkTypeUInt64Array vtkTypeUInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt64Array.vtkTypeUInt64Array_FastDownCast_01((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt64Array = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt64Array.Register(null);
				}
			}
			return vtkTypeUInt64Array;
		}

		// Token: 0x0601E12C RID: 123180
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt64Array_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E12D RID: 123181 RVA: 0x002A85E0 File Offset: 0x002A67E0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTypeUInt64Array.vtkTypeUInt64Array_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E12E RID: 123182
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTypeUInt64Array_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E12F RID: 123183 RVA: 0x002A8600 File Offset: 0x002A6800
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTypeUInt64Array.vtkTypeUInt64Array_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E130 RID: 123184
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt64Array_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E131 RID: 123185 RVA: 0x002A861C File Offset: 0x002A681C
		public override int IsA(string type)
		{
			return vtkTypeUInt64Array.vtkTypeUInt64Array_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E132 RID: 123186
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTypeUInt64Array_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x0601E133 RID: 123187 RVA: 0x002A863C File Offset: 0x002A683C
		public new static int IsTypeOf(string type)
		{
			return vtkTypeUInt64Array.vtkTypeUInt64Array_IsTypeOf_05(type);
		}

		// Token: 0x0601E134 RID: 123188
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt64Array_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E135 RID: 123189 RVA: 0x002A8658 File Offset: 0x002A6858
		public new vtkTypeUInt64Array NewInstance()
		{
			vtkTypeUInt64Array result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt64Array.vtkTypeUInt64Array_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E136 RID: 123190
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTypeUInt64Array_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x0601E137 RID: 123191 RVA: 0x002A86B4 File Offset: 0x002A68B4
		public new static vtkTypeUInt64Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeUInt64Array vtkTypeUInt64Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTypeUInt64Array.vtkTypeUInt64Array_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt64Array = (vtkTypeUInt64Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt64Array.Register(null);
				}
			}
			return vtkTypeUInt64Array;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FBF RID: 8127
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeUInt64Array";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FC0 RID: 8128
		public new static readonly string MRClassNameKey = "class vtkTypeUInt64Array";
	}
}
