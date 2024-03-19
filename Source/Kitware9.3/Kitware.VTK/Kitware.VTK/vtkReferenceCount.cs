using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReferenceCount
	/// </summary>
	/// <remarks>
	///    Obsolete / empty subclass of object.
	///
	/// vtkReferenceCount functionality has now been moved into vtkObject
	/// </remarks>
	/// <seealso>
	///
	/// vtkObject
	/// </seealso>
	// Token: 0x02000B7C RID: 2940
	public class vtkReferenceCount : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EB05 RID: 125701 RVA: 0x002B84BF File Offset: 0x002B66BF
		static vtkReferenceCount()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReferenceCount.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReferenceCount"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB06 RID: 125702 RVA: 0x002B84E7 File Offset: 0x002B66E7
		public vtkReferenceCount(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EB07 RID: 125703
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReferenceCount_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB08 RID: 125704 RVA: 0x002B84F8 File Offset: 0x002B66F8
		public new static vtkReferenceCount New()
		{
			vtkReferenceCount result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReferenceCount.vtkReferenceCount_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReferenceCount)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB09 RID: 125705 RVA: 0x002B854C File Offset: 0x002B674C
		public vtkReferenceCount() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkReferenceCount.vtkReferenceCount_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB0A RID: 125706 RVA: 0x002B8590 File Offset: 0x002B6790
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EB0B RID: 125707
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReferenceCount_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB0C RID: 125708 RVA: 0x002B859C File Offset: 0x002B679C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReferenceCount.vtkReferenceCount_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601EB0D RID: 125709
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReferenceCount_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB0E RID: 125710 RVA: 0x002B85BC File Offset: 0x002B67BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReferenceCount.vtkReferenceCount_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601EB0F RID: 125711
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReferenceCount_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB10 RID: 125712 RVA: 0x002B85D8 File Offset: 0x002B67D8
		public override int IsA(string type)
		{
			return vtkReferenceCount.vtkReferenceCount_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601EB11 RID: 125713
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReferenceCount_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB12 RID: 125714 RVA: 0x002B85F8 File Offset: 0x002B67F8
		public new static int IsTypeOf(string type)
		{
			return vtkReferenceCount.vtkReferenceCount_IsTypeOf_04(type);
		}

		// Token: 0x0601EB13 RID: 125715
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReferenceCount_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB14 RID: 125716 RVA: 0x002B8614 File Offset: 0x002B6814
		public new vtkReferenceCount NewInstance()
		{
			vtkReferenceCount result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReferenceCount.vtkReferenceCount_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReferenceCount)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EB15 RID: 125717
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReferenceCount_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB16 RID: 125718 RVA: 0x002B8670 File Offset: 0x002B6870
		public new static vtkReferenceCount SafeDownCast(vtkObjectBase o)
		{
			vtkReferenceCount vtkReferenceCount = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReferenceCount.vtkReferenceCount_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReferenceCount = (vtkReferenceCount)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReferenceCount.Register(null);
				}
			}
			return vtkReferenceCount;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020DC RID: 8412
		public new const string MRFullTypeName = "Kitware.VTK.vtkReferenceCount";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020DD RID: 8413
		public new static readonly string MRClassNameKey = "class vtkReferenceCount";
	}
}
