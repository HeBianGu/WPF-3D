using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWeakReference
	/// </summary>
	/// <remarks>
	///    Utility class to hold a weak reference to a vtkObject.
	///
	/// Simple Set(...)/Get(...) interface. Used in numpy support to provide a
	/// reference to a vtkObject without preventing it from being collected.
	/// </remarks>
	// Token: 0x02000B8A RID: 2954
	public class vtkWeakReference : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601ED13 RID: 126227 RVA: 0x002BB4F7 File Offset: 0x002B96F7
		static vtkWeakReference()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWeakReference.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWeakReference"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED14 RID: 126228 RVA: 0x002BB51F File Offset: 0x002B971F
		public vtkWeakReference(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601ED15 RID: 126229
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeakReference_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED16 RID: 126230 RVA: 0x002BB530 File Offset: 0x002B9730
		public new static vtkWeakReference New()
		{
			vtkWeakReference result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeakReference.vtkWeakReference_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWeakReference)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED17 RID: 126231 RVA: 0x002BB584 File Offset: 0x002B9784
		public vtkWeakReference() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWeakReference.vtkWeakReference_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601ED18 RID: 126232 RVA: 0x002BB5C8 File Offset: 0x002B97C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601ED19 RID: 126233
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeakReference_Get_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkObject pointer or nullptr if the object has been collected.
		/// </summary>
		// Token: 0x0601ED1A RID: 126234 RVA: 0x002BB5D4 File Offset: 0x002B97D4
		public vtkObject Get()
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeakReference.vtkWeakReference_Get_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x0601ED1B RID: 126235
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWeakReference_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED1C RID: 126236 RVA: 0x002BB644 File Offset: 0x002B9844
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWeakReference.vtkWeakReference_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601ED1D RID: 126237
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWeakReference_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED1E RID: 126238 RVA: 0x002BB664 File Offset: 0x002B9864
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWeakReference.vtkWeakReference_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601ED1F RID: 126239
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWeakReference_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED20 RID: 126240 RVA: 0x002BB680 File Offset: 0x002B9880
		public override int IsA(string type)
		{
			return vtkWeakReference.vtkWeakReference_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601ED21 RID: 126241
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWeakReference_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED22 RID: 126242 RVA: 0x002BB6A0 File Offset: 0x002B98A0
		public new static int IsTypeOf(string type)
		{
			return vtkWeakReference.vtkWeakReference_IsTypeOf_05(type);
		}

		// Token: 0x0601ED23 RID: 126243
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeakReference_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED24 RID: 126244 RVA: 0x002BB6BC File Offset: 0x002B98BC
		public new vtkWeakReference NewInstance()
		{
			vtkWeakReference result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeakReference.vtkWeakReference_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWeakReference)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601ED25 RID: 126245
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWeakReference_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601ED26 RID: 126246 RVA: 0x002BB718 File Offset: 0x002B9918
		public new static vtkWeakReference SafeDownCast(vtkObjectBase o)
		{
			vtkWeakReference vtkWeakReference = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWeakReference.vtkWeakReference_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWeakReference = (vtkWeakReference)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWeakReference.Register(null);
				}
			}
			return vtkWeakReference;
		}

		// Token: 0x0601ED27 RID: 126247
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWeakReference_Set_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the vtkObject to maintain a weak reference to.
		/// </summary>
		// Token: 0x0601ED28 RID: 126248 RVA: 0x002BB798 File Offset: 0x002B9998
		public void Set(vtkObject arg0)
		{
			vtkWeakReference.vtkWeakReference_Set_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002104 RID: 8452
		public new const string MRFullTypeName = "Kitware.VTK.vtkWeakReference";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002105 RID: 8453
		public new static readonly string MRClassNameKey = "class vtkWeakReference";
	}
}
